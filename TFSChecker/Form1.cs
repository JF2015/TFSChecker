/*
   PACKAGE:    TFS Checker application
   FILE:       Chart.cs
   ABSTRACT:   Chart form which displays the results of TFS stats tool
   AUTHOR:     Jens Fiedler
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace TFS2010
{
    public partial class Form1 : Form
    {
        public Dictionary<string, int> m_Committers = new Dictionary<string, int>();
        public Dictionary<string, Dictionary<DateTime, int>> m_Checkins = new Dictionary<string, Dictionary<DateTime, int>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                m_Committers.Clear();
                m_Checkins.Clear();
                richTextBox1.Text = "";
                textBox2.ReadOnly = true;
                TfsTeamProjectCollection tfsProjectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(textBox2.Text));

                var versionControl = tfsProjectCollection.GetService<VersionControlServer>();

                IEnumerable results = versionControl.QueryHistory("$/", VersionSpec.Latest, 0, RecursionType.Full, null, null, null, int.MaxValue, true, true);
                List<Changeset> changesets = results.Cast<Changeset>().ToList();

                if (0 < changesets.Count)
                {
                    foreach (Changeset changeset in changesets)
                    {
                        if (changeset.Comment.Contains("build incremented version to"))
                            continue;
                        string committer = changeset.Committer;
                        if (m_Committers.ContainsKey(committer))
                        {
                            m_Committers[committer] += 1;
                            m_Checkins[committer].Add(changeset.CreationDate, changeset.Changes.Length);
                        }
                        else
                        {
                            if (committer.Length > 10)
                                committer = committer.Substring(0, 10);
                            m_Committers.Add(committer, 1);
                            Dictionary<DateTime, int> dic = new Dictionary<DateTime, int>();
                            dic.Add(changeset.CreationDate, 1);
                            m_Checkins.Add(committer, dic);
                        }
                    }
                }

                foreach (KeyValuePair<string, int> pair in m_Committers.OrderByDescending(key => key.Value))
                {
                    richTextBox1.Text += pair.Key + (" ").PadLeft(15 - pair.Key.Length) + pair.Value;
                    richTextBox1.Text += Environment.NewLine;
                }
                ChartForm frm = new ChartForm(this);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox2.ReadOnly = false;
        }
    }
}
