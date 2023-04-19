using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Shaman_PAM_Solution
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            // Create a new NotifyIcon object
            NotifyIcon notifyIcon = new NotifyIcon();

            // Set the icon to display in the system tray
            notifyIcon.Icon = new System.Drawing.Icon("icon.ico");

            // Set the tooltip text
            notifyIcon.Text = "Shaman PAM Solution";

            // Create a new ContextMenuStrip object
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            // Add "Show Window" menu item to the context menu
            contextMenuStrip.Items.Add("Show Window", null, (sender, e) =>
            {
                // Handle "Show Window" menu item click event
                MainForm form = new MainForm();
                form.Show();
            });

            // Add "Exit" menu item to the context menu
            contextMenuStrip.Items.Add("Exit", null, (sender, e) =>
            {
                // Handle "Exit" menu item click event
                notifyIcon.Visible = false;
                Application.Exit();
            });

            // Set the context menu for the notification icon
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            // Display the notification icon in the system tray
            notifyIcon.Visible = true;

            // Wait for the user to click on the notification icon
            notifyIcon.MouseClick += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    // Handle left-click event
                }
            };

            // Wait for the user to close the application
            Application.Run();
        }

       
    }
}