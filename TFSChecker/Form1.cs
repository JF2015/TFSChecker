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
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace TFS2010
{
    public partial class Form1 : Form
    {
        public Dictionary<string, int> Committers = new Dictionary<string, int>();
        public Dictionary<string, Dictionary<DateTime, int>> Checkins = new Dictionary<string, Dictionary<DateTime, int>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxCommitters.Text = "";
            richTextBoxCommitters.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Committers.Clear();
                Checkins.Clear();
                richTextBoxCommitters.Text = "";
                var tfsProjectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(txtBoxServerAdress.Text));

                var versionControl = tfsProjectCollection.GetService<VersionControlServer>();

                var results = versionControl.QueryHistory("$/", VersionSpec.Latest, 0, RecursionType.Full, null, null, null, int.MaxValue, true, true);
                var changesets = results.Cast<Changeset>().ToList();

                if (0 < changesets.Count)
                {
                    foreach (var changeset in changesets)
                    {
                        if (changeset.Comment.Contains("build incremented version to"))
                            continue;
                        var committer = changeset.Committer;
                        if (Committers.ContainsKey(committer))
                        {
                            Committers[committer] += 1;
                            Checkins[committer].Add(changeset.CreationDate, changeset.Changes.Length);
                        }
                        else
                        {
                            //if (committer.Length > 10)
                            //    committer = committer.Substring(0, 10);
                            Committers.Add(committer, 1);
                            var dic = new Dictionary<DateTime, int> { { changeset.CreationDate, 1 } };
                            Checkins.Add(committer, dic);
                        }
                    }
                }

                foreach (var pair in Committers.OrderByDescending(key => key.Value))
                {
                    richTextBoxCommitters.Text += pair.Key + (" ") + pair.Value;
                    richTextBoxCommitters.Text += Environment.NewLine;
                }
                var frm = new ChartForm(this);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}