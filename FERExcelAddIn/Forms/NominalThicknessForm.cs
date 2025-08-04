using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class NominalThicknessForm : Form
    {
        private readonly Dictionary<string, Dictionary<string, ScheduleData>> _pipeData = new Dictionary<string, Dictionary<string, ScheduleData>>();

        public NominalThicknessForm()
        {
            InitializeComponent();
            InitializePipeData();
            LoadDropdowns();
        }

        private class ScheduleData
        {
            public double? Thickness { get; set; }
            public double OuterDiameter { get; set; }
        }

        private void InitializePipeData()
        {
            var pipeSizes = new List<Dictionary<string, object>>
            {
                new Dictionary<string, object>
                {
                    {"Size", "0.125"}, {"OD", 0.405},
                    {"5", null}, {"5s", null}, {"10", 0.049}, {"10s", 0.049}, {"20", null}, {"30", 0.057},
                    {"40", 0.068}, {"40s", 0.068}, {"STD", 0.068}, {"60", null}, {"80", 0.095}, {"80s", 0.095},
                    {"XS", 0.095}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "0.25"}, {"OD", 0.54},
                    {"5", null}, {"5s", null}, {"10", 0.065}, {"10s", 0.065}, {"20", null}, {"30", 0.073},
                    {"40", 0.088}, {"40s", 0.088}, {"STD", 0.088}, {"60", null}, {"80", 0.119}, {"80s", 0.119},
                    {"XS", 0.119}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "0.375"}, {"OD", 0.675},
                    {"5", null}, {"5s", null}, {"10", 0.065}, {"10s", 0.065}, {"20", null}, {"30", 0.073},
                    {"40", 0.091}, {"40s", 0.091}, {"STD", 0.091}, {"60", null}, {"80", 0.126}, {"80s", 0.126},
                    {"XS", 0.126}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "0.5"}, {"OD", 0.84},
                    {"5", 0.065}, {"5s", 0.065}, {"10", 0.083}, {"10s", 0.083}, {"20", null}, {"30", 0.095},
                    {"40", 0.109}, {"40s", 0.109}, {"STD", 0.109}, {"60", null}, {"80", 0.147}, {"80s", 0.147},
                    {"XS", 0.147}, {"100", null}, {"120", null}, {"140", null}, {"160", 0.188}, {"XXS", 0.294}
                },
                new Dictionary<string, object>
                {
                    {"Size", "0.75"}, {"OD", 1.05},
                    {"5", 0.065}, {"5s", 0.065}, {"10", 0.083}, {"10s", 0.083}, {"20", null}, {"30", 0.095},
                    {"40", 0.113}, {"40s", 0.113}, {"STD", 0.113}, {"60", null}, {"80", 0.154}, {"80s", 0.154},
                    {"XS", 0.154}, {"100", null}, {"120", null}, {"140", null}, {"160", 0.219}, {"XXS", 0.308}
                },
                new Dictionary<string, object>
                {
                    {"Size", "1"}, {"OD", 1.315},
                    {"5", 0.065}, {"5s", 0.065}, {"10", 0.109}, {"10s", 0.109}, {"20", null}, {"30", 0.114},
                    {"40", 0.133}, {"40s", 0.133}, {"STD", 0.133}, {"60", null}, {"80", 0.179}, {"80s", 0.179},
                    {"XS", 0.179}, {"100", null}, {"120", null}, {"140", null}, {"160", 0.25}, {"XXS", 0.358}
                },
                new Dictionary<string, object>
                {
                    {"Size", "1.25"}, {"OD", 1.66},
                    {"5", 0.065}, {"5s", 0.065}, {"10", 0.109}, {"10s", 0.109}, {"20", null}, {"30", 0.117},
                    {"40", 0.14}, {"40s", 0.14}, {"STD", 0.14}, {"60", null}, {"80", 0.191}, {"80s", 0.191},
                    {"XS", 0.191}, {"100", null}, {"120", null}, {"140", null}, {"160", 0.25}, {"XXS", 0.382}
                },
                new Dictionary<string, object>
                {
                    {"Size", "1.5"}, {"OD", 1.9},
                    {"5", 0.065}, {"5s", 0.065}, {"10", 0.109}, {"10s", 0.109}, {"20", null}, {"30", 0.125},
                    {"40", 0.145}, {"40s", 0.145}, {"STD", 0.145}, {"60", null}, {"80", 0.2}, {"80s", 0.2},
                    {"XS", 0.2}, {"100", null}, {"120", null}, {"140", null}, {"160", 0.281}, {"XXS", 0.4}
                },
                new Dictionary<string, object>
                {
                    {"Size", "2"}, {"OD", 2.375},
                    {"5", 0.065}, {"5s", 0.065}, {"10", 0.109}, {"10s", 0.109}, {"20", null}, {"30", 0.125},
                    {"40", 0.154}, {"40s", 0.154}, {"STD", 0.154}, {"60", null}, {"80", 0.218}, {"80s", 0.218},
                    {"XS", 0.218}, {"100", null}, {"120", null}, {"140", null}, {"160", 0.344}, {"XXS", 0.436}
                },
                new Dictionary<string, object>
                {
                    {"Size", "2.5"}, {"OD", 2.875},
                    {"5", 0.083}, {"5s", 0.083}, {"10", 0.12}, {"10s", 0.12}, {"20", null}, {"30", 0.188},
                    {"40", 0.203}, {"40s", 0.203}, {"STD", 0.203}, {"60", null}, {"80", 0.276}, {"80s", 0.276},
                    {"XS", 0.276}, {"100", null}, {"120", null}, {"140", null}, {"160", 0.375}, {"XXS", 0.552}
                },
                new Dictionary<string, object>
                {
                    {"Size", "3"}, {"OD", 3.5},
                    {"5", 0.083}, {"5s", 0.083}, {"10", 0.12}, {"10s", 0.12}, {"20", null}, {"30", 0.188},
                    {"40", 0.216}, {"40s", 0.216}, {"STD", 0.216}, {"60", null}, {"80", 0.3}, {"80s", 0.3},
                    {"XS", 0.3}, {"100", null}, {"120", null}, {"140", null}, {"160", 0.438}, {"XXS", 0.6}
                },
                new Dictionary<string, object>
                {
                    {"Size", "3.5"}, {"OD", 4.0},
                    {"5", 0.083}, {"5s", 0.083}, {"10", 0.12}, {"10s", 0.12}, {"20", null}, {"30", 0.188},
                    {"40", 0.226}, {"40s", 0.226}, {"STD", 0.226}, {"60", null}, {"80", 0.318}, {"80s", 0.318},
                    {"XS", 0.318}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", 0.636}
                },
                new Dictionary<string, object>
                {
                    {"Size", "4"}, {"OD", 4.5},
                    {"5", 0.083}, {"5s", 0.083}, {"10", 0.12}, {"10s", 0.12}, {"20", null}, {"30", 0.188},
                    {"40", 0.237}, {"40s", 0.237}, {"STD", 0.237}, {"60", null}, {"80", 0.337}, {"80s", 0.337},
                    {"XS", 0.337}, {"100", 0.438}, {"120", null}, {"140", null}, {"160", 0.531}, {"XXS", 0.674}
                },
                new Dictionary<string, object>
                {
                    {"Size", "6"}, {"OD", 6.625},
                    {"5", 0.109}, {"5s", 0.109}, {"10", 0.134}, {"10s", 0.134}, {"20", null}, {"30", null},
                    {"40", 0.28}, {"40s", 0.28}, {"STD", 0.28}, {"60", null}, {"80", 0.432}, {"80s", 0.432},
                    {"XS", 0.432}, {"100", 0.562}, {"120", null}, {"140", null}, {"160", 0.719}, {"XXS", 0.864}
                },
                new Dictionary<string, object>
                {
                    {"Size", "8"}, {"OD", 8.625},
                    {"5", 0.109}, {"5s", 0.109}, {"10", 0.148}, {"10s", 0.148}, {"20", 0.25}, {"30", 0.277},
                    {"40", 0.322}, {"40s", 0.322}, {"STD", 0.322}, {"60", 0.406}, {"80", 0.5}, {"80s", 0.5},
                    {"XS", 0.5}, {"100", 0.594}, {"120", 0.719}, {"140", 0.812}, {"160", 0.906}, {"XXS", 0.875}
                },
                new Dictionary<string, object>
                {
                    {"Size", "10"}, {"OD", 10.75},
                    {"5", 0.134}, {"5s", 0.134}, {"10", 0.165}, {"10s", 0.165}, {"20", 0.25}, {"30", 0.307},
                    {"40", 0.365}, {"40s", 0.365}, {"STD", 0.365}, {"60", 0.5}, {"80", 0.594}, {"80s", 0.5},
                    {"XS", 0.5}, {"100", 0.719}, {"120", 0.844}, {"140", 1.0}, {"160", 1.125}, {"XXS", 1.0}
                },
                new Dictionary<string, object>
                {
                    {"Size", "12"}, {"OD", 12.75},
                    {"5", 0.156}, {"5s", 0.156}, {"10", 0.18}, {"10s", 0.18}, {"20", 0.25}, {"30", 0.33},
                    {"40", 0.406}, {"40s", 0.375}, {"STD", 0.375}, {"60", 0.562}, {"80", 0.688}, {"80s", 0.5},
                    {"XS", 0.5}, {"100", 0.844}, {"120", 1.0}, {"140", 1.125}, {"160", 1.312}, {"XXS", 1.0}
                },
                new Dictionary<string, object>
                {
                    {"Size", "14"}, {"OD", 14.0},
                    {"5", 0.156}, {"5s", 0.156}, {"10", 0.25}, {"10s", 0.188}, {"20", 0.312}, {"30", 0.375},
                    {"40", 0.438}, {"40s", 0.375}, {"STD", 0.375}, {"60", 0.594}, {"80", 0.75}, {"80s", 0.5},
                    {"XS", 0.5}, {"100", 0.938}, {"120", 1.094}, {"140", 1.25}, {"160", 1.406}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "16"}, {"OD", 16.0},
                    {"5", 0.165}, {"5s", 0.165}, {"10", 0.25}, {"10s", 0.188}, {"20", 0.312}, {"30", 0.375},
                    {"40", 0.5}, {"40s", 0.375}, {"STD", 0.375}, {"60", 0.656}, {"80", 0.844}, {"80s", 0.5},
                    {"XS", 0.5}, {"100", 1.031}, {"120", 1.219}, {"140", 1.438}, {"160", 1.594}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "18"}, {"OD", 18.0},
                    {"5", 0.165}, {"5s", 0.165}, {"10", 0.25}, {"10s", 0.188}, {"20", 0.312}, {"30", 0.438},
                    {"40", 0.562}, {"40s", 0.375}, {"STD", 0.375}, {"60", 0.75}, {"80", 0.938}, {"80s", 0.5},
                    {"XS", 0.5}, {"100", 1.156}, {"120", 1.375}, {"140", 1.562}, {"160", 1.781}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "20"}, {"OD", 20.0},
                    {"5", 0.188}, {"5s", 0.188}, {"10", 0.25}, {"10s", 0.218}, {"20", 0.375}, {"30", 0.5},
                    {"40", 0.594}, {"40s", 0.375}, {"STD", 0.375}, {"60", 0.812}, {"80", 1.031}, {"80s", 0.5},
                    {"XS", 0.5}, {"100", 1.281}, {"120", 1.5}, {"140", 1.75}, {"160", 1.969}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "22"}, {"OD", 22.0},
                    {"5", 0.188}, {"5s", 0.188}, {"10", 0.25}, {"10s", 0.218}, {"20", 0.375}, {"30", 0.5},
                    {"40", null}, {"40s", null}, {"STD", 0.375}, {"60", 0.875}, {"80", 1.125}, {"80s", null},
                    {"XS", 0.5}, {"100", 1.375}, {"120", 1.625}, {"140", 1.875}, {"160", 2.125}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "24"}, {"OD", 24.0},
                    {"5", 0.218}, {"5s", 0.218}, {"10", 0.25}, {"10s", 0.25}, {"20", 0.375}, {"30", 0.562},
                    {"40", 0.688}, {"40s", 0.375}, {"STD", 0.375}, {"60", 0.969}, {"80", 1.218}, {"80s", 0.5},
                    {"XS", 0.5}, {"100", 1.531}, {"120", 1.812}, {"140", 2.062}, {"160", 2.344}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "26"}, {"OD", 26.0},
                    {"5", null}, {"5s", null}, {"10", 0.312}, {"10s", null}, {"20", 0.5}, {"30", null},
                    {"40", null}, {"40s", null}, {"STD", 0.375}, {"60", null}, {"80", null}, {"80s", null},
                    {"XS", 0.5}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "28"}, {"OD", 28.0},
                    {"5", null}, {"5s", null}, {"10", 0.312}, {"10s", null}, {"20", 0.5}, {"30", 0.625},
                    {"40", null}, {"40s", null}, {"STD", 0.375}, {"60", null}, {"80", null}, {"80s", null},
                    {"XS", 0.5}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "30"}, {"OD", 30.0},
                    {"5", 0.25}, {"5s", 0.25}, {"10", 0.312}, {"10s", 0.312}, {"20", 0.5}, {"30", 0.625},
                    {"40", null}, {"40s", null}, {"STD", 0.375}, {"60", null}, {"80", null}, {"80s", null},
                    {"XS", 0.5}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "32"}, {"OD", 32.0},
                    {"5", null}, {"5s", null}, {"10", 0.312}, {"10s", null}, {"20", 0.5}, {"30", 0.625},
                    {"40", 0.688}, {"40s", null}, {"STD", 0.375}, {"60", null}, {"80", null}, {"80s", null},
                    {"XS", 0.5}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", null}
                },
                new Dictionary<string, object>
                {
                    {"Size", "34"}, {"OD", 34.0},
                    {"5", null}, {"5s", null}, {"10", 0.312}, {"10s", null}, {"20", 0.5}, {"30", 0.625},
                    {"40", 0.688}, {"40s", null}, {"STD", 0.375}, {"60", null}, {"80", null}, {"80s", null},
                    {"XS", 0.5}, {"100", null}, {"120", null}, {"140", null}, {"160", null}, {"XXS", null}
                }
            };

            // Convert to our dictionary structure
            foreach (var pipe in pipeSizes)
            {
                var size = pipe["Size"].ToString();
                var od = Convert.ToDouble(pipe["OD"]);
                var schedules = new Dictionary<string, ScheduleData>();

                foreach (var kvp in pipe)
                {
                    if (kvp.Key != "Size" && kvp.Key != "OD")
                    {
                        schedules[kvp.Key] = new ScheduleData
                        {
                            Thickness = kvp.Value != null ? Convert.ToDouble(kvp.Value) : (double?)null,
                            OuterDiameter = od
                        };
                    }
                }

                _pipeData.Add(size, schedules);
            }
        }

        private void LoadDropdowns()
        {
            try
            {
                // Pipe sizes
                cmbPipeSize.Items.Clear();
                foreach (var size in _pipeData.Keys)
                {
                    cmbPipeSize.Items.Add(size);
                }

                // Schedules (using first pipe size's schedules as template)
                if (_pipeData.Count > 0)
                {
                    cmbSchedule.Items.Clear();
                    foreach (var schedule in _pipeData["0.125"].Keys)
                    {
                        cmbSchedule.Items.Add(schedule);
                    }
                }

                if (cmbPipeSize.Items.Count > 0) cmbPipeSize.SelectedIndex = 0;
                if (cmbSchedule.Items.Count > 0) cmbSchedule.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear all fields first
                txtThickness.Text = "";
                txtUpperMil.Text = "";
                txtLowerMil.Text = "";
                txtOD.Text = "";
                txtID.Text = "";

                if (cmbPipeSize.SelectedItem == null || cmbSchedule.SelectedItem == null)
                {
                    MessageBox.Show("Please select both Pipe Size and Schedule");
                    return;
                }

                string pipeSize = cmbPipeSize.SelectedItem.ToString();
                string schedule = cmbSchedule.SelectedItem.ToString();

                if (_pipeData.TryGetValue(pipeSize, out var schedules))
                {
                    if (schedules.TryGetValue(schedule, out var scheduleData))
                    {
                        if (scheduleData.Thickness.HasValue)
                        {
                            double nominal = scheduleData.Thickness.Value;
                            double od = scheduleData.OuterDiameter;
                            double id = od - (2 * nominal);

                            // Calculate tolerances
                            double upperTol = Math.Round(nominal * 1.125, 4);  // +12.5%
                            double lowerTol = Math.Round(nominal * 0.875, 4);  // -12.5%

                            // Populate all text boxes
                            txtThickness.Text = $"{nominal}\"";
                            txtUpperMil.Text = $"{upperTol:0.000}\"";
                            txtLowerMil.Text = $"{lowerTol:0.000}\"";
                            txtOD.Text = $"{od}\"";
                            txtID.Text = $"{id:0.000}\"";
                        }
                        else
                        {
                            txtThickness.Text = "N/A";
                            txtUpperMil.Text = "N/A";
                            txtLowerMil.Text = "N/A";
                            txtOD.Text = "N/A";
                            txtID.Text = "N/A";
                        }
                    }
                    else
                    {
                        txtThickness.Text = $"Schedule '{schedule}' not found";
                        txtUpperMil.Text = "N/A";
                        txtLowerMil.Text = "N/A";
                        txtOD.Text = "N/A";
                        txtID.Text = "N/A";
                    }
                }
                else
                {
                    txtThickness.Text = $"Pipe size '{pipeSize}' not found";
                    txtUpperMil.Text = "N/A";
                    txtLowerMil.Text = "N/A";
                    txtOD.Text = "N/A";
                    txtID.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                txtThickness.Text = "Error";
                txtUpperMil.Text = "Error";
                txtLowerMil.Text = "Error";
                txtOD.Text = "Error";
                txtID.Text = "Error";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblThickness_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void lblLowerMil_Click(object sender, EventArgs e)
        {

        }
    }
}