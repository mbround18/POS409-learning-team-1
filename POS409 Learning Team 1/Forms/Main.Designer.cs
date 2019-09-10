namespace POS409_Learning_Team_1.Forms
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.sourceTextBox = new System.Windows.Forms.RichTextBox();
            this.destinationTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.navigateBtn = new System.Windows.Forms.Button();
            this.searchSourceBtn = new System.Windows.Forms.Button();
            this.searchDestinationBtn = new System.Windows.Forms.Button();
            this.saveDestinationAddressBtn = new System.Windows.Forms.Button();
            this.saveSourceAddressBtn = new System.Windows.Forms.Button();
            this.viewAddressBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(454, 12);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 17;
            this.gMapControl.MinZoom = 1;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(1019, 599);
            this.gMapControl.TabIndex = 2;
            this.gMapControl.Zoom = 10D;
            this.gMapControl.Load += new System.EventHandler(this.GMapControl_Load);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTextBox.Location = new System.Drawing.Point(12, 51);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(436, 81);
            this.sourceTextBox.TabIndex = 3;
            this.sourceTextBox.Text = "";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationTextBox.Location = new System.Drawing.Point(12, 277);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(436, 81);
            this.destinationTextBox.TabIndex = 4;
            this.destinationTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source Address";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination Address";
            // 
            // navigateBtn
            // 
            this.navigateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.navigateBtn.Location = new System.Drawing.Point(60, 449);
            this.navigateBtn.Name = "navigateBtn";
            this.navigateBtn.Size = new System.Drawing.Size(315, 62);
            this.navigateBtn.TabIndex = 7;
            this.navigateBtn.Text = "Navigate";
            this.navigateBtn.UseVisualStyleBackColor = true;
            this.navigateBtn.Click += new System.EventHandler(this.NavigateBtn_Click);
            // 
            // searchSourceBtn
            // 
            this.searchSourceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSourceBtn.Location = new System.Drawing.Point(12, 138);
            this.searchSourceBtn.Name = "searchSourceBtn";
            this.searchSourceBtn.Size = new System.Drawing.Size(112, 23);
            this.searchSourceBtn.TabIndex = 8;
            this.searchSourceBtn.Text = "Search  ( Optional )";
            this.searchSourceBtn.UseVisualStyleBackColor = true;
            this.searchSourceBtn.Click += new System.EventHandler(this.SearchSourceBtn_Click);
            // 
            // searchDestinationBtn
            // 
            this.searchDestinationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDestinationBtn.Location = new System.Drawing.Point(12, 364);
            this.searchDestinationBtn.Name = "searchDestinationBtn";
            this.searchDestinationBtn.Size = new System.Drawing.Size(112, 23);
            this.searchDestinationBtn.TabIndex = 9;
            this.searchDestinationBtn.Text = "Search  ( Optional )";
            this.searchDestinationBtn.UseVisualStyleBackColor = true;
            this.searchDestinationBtn.Click += new System.EventHandler(this.SearchDestinationBtn_Click);
            // 
            // saveDestinationAddressBtn
            // 
            this.saveDestinationAddressBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDestinationAddressBtn.Location = new System.Drawing.Point(336, 364);
            this.saveDestinationAddressBtn.Name = "saveDestinationAddressBtn";
            this.saveDestinationAddressBtn.Size = new System.Drawing.Size(112, 23);
            this.saveDestinationAddressBtn.TabIndex = 10;
            this.saveDestinationAddressBtn.Text = "Save Dest. Address";
            this.saveDestinationAddressBtn.UseVisualStyleBackColor = true;
            this.saveDestinationAddressBtn.Click += new System.EventHandler(this.SaveDestinationAddressBtn_Click);
            // 
            // saveSourceAddressBtn
            // 
            this.saveSourceAddressBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSourceAddressBtn.Location = new System.Drawing.Point(336, 138);
            this.saveSourceAddressBtn.Name = "saveSourceAddressBtn";
            this.saveSourceAddressBtn.Size = new System.Drawing.Size(112, 23);
            this.saveSourceAddressBtn.TabIndex = 11;
            this.saveSourceAddressBtn.Text = "Save Src. Address";
            this.saveSourceAddressBtn.UseVisualStyleBackColor = true;
            this.saveSourceAddressBtn.Click += new System.EventHandler(this.SaveSourceAddressBtn_Click);
            // 
            // viewAddressBookBtn
            // 
            this.viewAddressBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAddressBookBtn.Location = new System.Drawing.Point(60, 542);
            this.viewAddressBookBtn.Name = "viewAddressBookBtn";
            this.viewAddressBookBtn.Size = new System.Drawing.Size(315, 58);
            this.viewAddressBookBtn.TabIndex = 13;
            this.viewAddressBookBtn.Text = "View Address Book";
            this.viewAddressBookBtn.UseVisualStyleBackColor = true;
            this.viewAddressBookBtn.Click += new System.EventHandler(this.ViewAddressBookBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 623);
            this.Controls.Add(this.viewAddressBookBtn);
            this.Controls.Add(this.saveSourceAddressBtn);
            this.Controls.Add(this.saveDestinationAddressBtn);
            this.Controls.Add(this.searchDestinationBtn);
            this.Controls.Add(this.searchSourceBtn);
            this.Controls.Add(this.navigateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.gMapControl);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.RichTextBox sourceTextBox;
        private System.Windows.Forms.RichTextBox destinationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button navigateBtn;
        private System.Windows.Forms.Button searchSourceBtn;
        private System.Windows.Forms.Button searchDestinationBtn;
        private System.Windows.Forms.Button saveDestinationAddressBtn;
        private System.Windows.Forms.Button saveSourceAddressBtn;
        private System.Windows.Forms.Button viewAddressBookBtn;
    }
}