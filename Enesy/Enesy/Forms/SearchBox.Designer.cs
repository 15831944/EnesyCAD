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
            this.butColumn = new System.Windows.Forms.Button();
            this.txtFilter = new Enesy.Forms.TextBoxFilter();
            this.SuspendLayout();
            // 
            // butSearch
            // 
            this.butSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.butSearch.FlatAppearance.BorderSize = 0;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearch.Image = global::Enesy.Properties.Resources.SearchButtonDisable;
            this.butSearch.Location = new System.Drawing.Point(229, 0);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(23, 23);
            this.butSearch.TabIndex = 2;
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // butColumn
            // 
            this.butColumn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.butColumn.FlatAppearance.BorderSize = 0;
            this.butColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butColumn.Image = global::Enesy.Properties.Resources.Filter;
            this.butColumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butColumn.Location = new System.Drawing.Point(0, 0);
            this.butColumn.Margin = new System.Windows.Forms.Padding(0);
            this.butColumn.Name = "butColumn";
            this.butColumn.Size = new System.Drawing.Size(40, 23);
            this.butColumn.TabIndex = 1;
            this.butColumn.Text = "▼";
            this.butColumn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.butColumn.UseVisualStyleBackColor = false;
            this.butColumn.Click += new System.EventHandler(this.butColumn_Click);
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
            this.txtFilter.Location = new System.Drawing.Point(45, 5);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(183, 13);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.Click += new System.EventHandler(this.txtFilter_Click);
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butColumn);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(130, 23);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(252, 23);
            this.SizeChanged += new System.EventHandler(this.SearchBox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxFilter txtFilter;
        private System.Windows.Forms.Button butColumn;
        private System.Windows.Forms.Button butSearch;
    }
}
