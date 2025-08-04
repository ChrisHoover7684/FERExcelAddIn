using Microsoft.Office.Tools.Ribbon;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace FERExcelAddIn
{
    public partial class ThisAddIn
    {
        private FERChartRibbon ribbon;

       

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            // Cleanup code
            ribbon = null;
        }

        public Stream GetGanttTemplateStream()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string[] allResources = assembly.GetManifestResourceNames();

                // Debug output
                Debug.WriteLine("Available Resources:");
                foreach (var resource in allResources)
                {
                    Debug.WriteLine(resource);
                }

                string resourceName = allResources.FirstOrDefault(r =>
                    r.EndsWith("Gantt-Chart-Template.xlsx", StringComparison.OrdinalIgnoreCase));

                if (resourceName == null)
                {
                    throw new FileNotFoundException(
                        "Gantt template not found. Available resources:\n" +
                        string.Join("\n", allResources));
                }

                var stream = assembly.GetManifestResourceStream(resourceName);

                if (stream == null)
                {
                    throw new FileNotFoundException(
                        "Could not load resource stream for: " + resourceName);
                }

                return stream;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading template: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                throw; // Re-throw to let caller handle
            }
        }

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            try
            {
                // C# 7.3 compatible null check
                if (ribbon == null)
                {
                    ribbon = new FERChartRibbon();
                }

                return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                    new IRibbonExtension[] { ribbon });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating ribbon: {ex.Message}",
                              "Ribbon Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                // Return minimal ribbon functionality if creation fails
                return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                    Array.Empty<IRibbonExtension>());
            }
        }

        #region VSTO generated code
        private void InternalStartup()
        {
            
            this.Shutdown += new EventHandler(ThisAddIn_Shutdown);
        }
        #endregion
    }
}