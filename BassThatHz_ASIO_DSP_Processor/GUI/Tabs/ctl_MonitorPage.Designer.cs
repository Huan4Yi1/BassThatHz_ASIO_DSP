
namespace BassThatHz_ASIO_DSP_Processor.GUI.Tabs
{
    partial class ctl_MonitorPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            btn_Monitor = new System.Windows.Forms.Button();
            btn_Align = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_Monitor
            // 
            btn_Monitor.Location = new System.Drawing.Point(3, 3);
            btn_Monitor.Name = "btn_Monitor";
            btn_Monitor.Size = new System.Drawing.Size(166, 22);
            btn_Monitor.TabIndex = 0;
            btn_Monitor.Text = "Open Monitoring Window";
            btn_Monitor.UseVisualStyleBackColor = true;
            btn_Monitor.Click += btn_Monitor_Click;
            // 
            // btn_Align
            // 
            btn_Align.Location = new System.Drawing.Point(3, 31);
            btn_Align.Name = "btn_Align";
            btn_Align.Size = new System.Drawing.Size(211, 22);
            btn_Align.TabIndex = 1;
            btn_Align.Text = "Open Crossover Alignment Window";
            btn_Align.UseVisualStyleBackColor = true;
            btn_Align.Click += btn_Align_Click;
            // 
            // ctl_MonitorPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btn_Align);
            Controls.Add(btn_Monitor);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "ctl_MonitorPage";
            Size = new System.Drawing.Size(545, 286);
            Load += ctl_MonitorPage_Load;
            ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btn_Monitor;
        protected System.Windows.Forms.Button btn_Align;
    }
}
