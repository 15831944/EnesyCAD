namespace Enesy.Forms
{
    partial class SearchBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.butSearch = new System.Windows.Forms.Button();
            this.txtFilter = new Enesy.Forms.TextBoxFilter();
            this.SuspendLayout();
            // 
            // butSearch
            // 
            this.butSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.butSearch.FlatAppearance.BorderSize = 0;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearch.Image = global::Enesy.Properties.Resources.SearchButtonDisable;
            this.butSearch.Location = new System.Drawing.Point(305, 0);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(31, 32);
            this.butSearch.TabIndex = 2;
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.DisplayMember = "";
            this.txtFilter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFilter.Location = new System.Drawing.Point(38, 6);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.SearchWaterMark = "";
            this.txtFilter.Size = new System.Drawing.Size(261, 20);
            this.txtFilter.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.butSearch);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(173, 26);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(336, 32);
            this.SizeChanged += new System.EventHandler(this.SearchBox_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxFilter txtFilter;
        private System.Windows.Forms.Button butSearch;
    }
}
