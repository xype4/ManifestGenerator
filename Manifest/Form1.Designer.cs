namespace Manifest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maxDuration = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.scenCount = new System.Windows.Forms.NumericUpDown();
            this.maxMark = new System.Windows.Forms.TextBox();
            this.passMark = new System.Windows.Forms.TextBox();
            this.updatedValuesGrid = new System.Windows.Forms.DataGridView();
            this.labelMaxDuration = new System.Windows.Forms.Label();
            this.labelMaxMark = new System.Windows.Forms.Label();
            this.defaultPassMark = new System.Windows.Forms.Label();
            this.sceneCount = new System.Windows.Forms.Label();
            this.defaultPassMarkApply = new System.Windows.Forms.Button();
            this.defaultMaxMarkApply = new System.Windows.Forms.Button();
            this.defaultMaxDurationApply = new System.Windows.Forms.Button();
            this.browseDirectory = new System.Windows.Forms.Button();
            this.directoryInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scenCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatedValuesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // maxDuration
            // 
            this.maxDuration.Location = new System.Drawing.Point(119, 42);
            this.maxDuration.Name = "maxDuration";
            this.maxDuration.Size = new System.Drawing.Size(100, 20);
            this.maxDuration.TabIndex = 0;
            this.maxDuration.Text = "3600";
            this.maxDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxDuration_KeyPress);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(119, 165);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Save";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // scenCount
            // 
            this.scenCount.Location = new System.Drawing.Point(119, 126);
            this.scenCount.Name = "scenCount";
            this.scenCount.ReadOnly = true;
            this.scenCount.Size = new System.Drawing.Size(104, 20);
            this.scenCount.TabIndex = 7;
            this.scenCount.ValueChanged += new System.EventHandler(this.scenCount_ValueChanged);
            // 
            // maxMark
            // 
            this.maxMark.Location = new System.Drawing.Point(119, 65);
            this.maxMark.Name = "maxMark";
            this.maxMark.Size = new System.Drawing.Size(100, 20);
            this.maxMark.TabIndex = 1;
            this.maxMark.Text = "100";
            this.maxMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxMark_KeyPress);
            // 
            // passMark
            // 
            this.passMark.Location = new System.Drawing.Point(119, 87);
            this.passMark.Name = "passMark";
            this.passMark.Size = new System.Drawing.Size(100, 20);
            this.passMark.TabIndex = 2;
            this.passMark.Text = "80";
            this.passMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passMark_KeyPress);
            // 
            // updatedValuesGrid
            // 
            this.updatedValuesGrid.AllowUserToAddRows = false;
            this.updatedValuesGrid.AllowUserToDeleteRows = false;
            this.updatedValuesGrid.AllowUserToResizeColumns = false;
            this.updatedValuesGrid.AllowUserToResizeRows = false;
            this.updatedValuesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updatedValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updatedValuesGrid.Location = new System.Drawing.Point(313, 16);
            this.updatedValuesGrid.Name = "updatedValuesGrid";
            this.updatedValuesGrid.Size = new System.Drawing.Size(418, 91);
            this.updatedValuesGrid.TabIndex = 8;
            // 
            // labelMaxDuration
            // 
            this.labelMaxDuration.AutoSize = true;
            this.labelMaxDuration.Location = new System.Drawing.Point(12, 45);
            this.labelMaxDuration.Name = "labelMaxDuration";
            this.labelMaxDuration.Size = new System.Drawing.Size(104, 13);
            this.labelMaxDuration.TabIndex = 9;
            this.labelMaxDuration.Text = "Default max duration";
            // 
            // labelMaxMark
            // 
            this.labelMaxMark.AutoSize = true;
            this.labelMaxMark.Location = new System.Drawing.Point(24, 68);
            this.labelMaxMark.Name = "labelMaxMark";
            this.labelMaxMark.Size = new System.Drawing.Size(89, 13);
            this.labelMaxMark.TabIndex = 10;
            this.labelMaxMark.Text = "Default max mark";
            // 
            // defaultPassMark
            // 
            this.defaultPassMark.AutoSize = true;
            this.defaultPassMark.Location = new System.Drawing.Point(24, 90);
            this.defaultPassMark.Name = "defaultPassMark";
            this.defaultPassMark.Size = new System.Drawing.Size(92, 13);
            this.defaultPassMark.TabIndex = 11;
            this.defaultPassMark.Text = "Default pass mark";
            // 
            // sceneCount
            // 
            this.sceneCount.AutoSize = true;
            this.sceneCount.Location = new System.Drawing.Point(45, 128);
            this.sceneCount.Name = "sceneCount";
            this.sceneCount.Size = new System.Drawing.Size(68, 13);
            this.sceneCount.TabIndex = 12;
            this.sceneCount.Text = "Scene count";
            // 
            // defaultPassMarkApply
            // 
            this.defaultPassMarkApply.Location = new System.Drawing.Point(225, 86);
            this.defaultPassMarkApply.Name = "defaultPassMarkApply";
            this.defaultPassMarkApply.Size = new System.Drawing.Size(73, 21);
            this.defaultPassMarkApply.TabIndex = 15;
            this.defaultPassMarkApply.Text = "Apply";
            this.defaultPassMarkApply.UseVisualStyleBackColor = true;
            this.defaultPassMarkApply.Click += new System.EventHandler(this.defaultPassMarkApply_Click);
            // 
            // defaultMaxMarkApply
            // 
            this.defaultMaxMarkApply.Location = new System.Drawing.Point(225, 64);
            this.defaultMaxMarkApply.Name = "defaultMaxMarkApply";
            this.defaultMaxMarkApply.Size = new System.Drawing.Size(73, 21);
            this.defaultMaxMarkApply.TabIndex = 14;
            this.defaultMaxMarkApply.Text = "Apply";
            this.defaultMaxMarkApply.UseVisualStyleBackColor = true;
            this.defaultMaxMarkApply.Click += new System.EventHandler(this.defaultMaxMarkApply_Click);
            // 
            // defaultMaxDurationApply
            // 
            this.defaultMaxDurationApply.Location = new System.Drawing.Point(225, 41);
            this.defaultMaxDurationApply.Name = "defaultMaxDurationApply";
            this.defaultMaxDurationApply.Size = new System.Drawing.Size(73, 21);
            this.defaultMaxDurationApply.TabIndex = 13;
            this.defaultMaxDurationApply.Text = "Apply";
            this.defaultMaxDurationApply.UseVisualStyleBackColor = true;
            this.defaultMaxDurationApply.Click += new System.EventHandler(this.defaultMaxDurationApply_Click);
            // 
            // browseDirectory
            // 
            this.browseDirectory.Location = new System.Drawing.Point(223, 165);
            this.browseDirectory.Name = "browseDirectory";
            this.browseDirectory.Size = new System.Drawing.Size(92, 23);
            this.browseDirectory.TabIndex = 16;
            this.browseDirectory.Text = "Browse catalog";
            this.browseDirectory.UseVisualStyleBackColor = true;
            this.browseDirectory.Click += new System.EventHandler(this.browseDirectory_Click);
            // 
            // directoryInfo
            // 
            this.directoryInfo.AutoSize = true;
            this.directoryInfo.Location = new System.Drawing.Point(321, 170);
            this.directoryInfo.Name = "directoryInfo";
            this.directoryInfo.Size = new System.Drawing.Size(0, 13);
            this.directoryInfo.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.directoryInfo);
            this.Controls.Add(this.browseDirectory);
            this.Controls.Add(this.defaultPassMarkApply);
            this.Controls.Add(this.defaultMaxMarkApply);
            this.Controls.Add(this.defaultMaxDurationApply);
            this.Controls.Add(this.sceneCount);
            this.Controls.Add(this.defaultPassMark);
            this.Controls.Add(this.labelMaxMark);
            this.Controls.Add(this.labelMaxDuration);
            this.Controls.Add(this.updatedValuesGrid);
            this.Controls.Add(this.scenCount);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.passMark);
            this.Controls.Add(this.maxMark);
            this.Controls.Add(this.maxDuration);
            this.Name = "Form1";
            this.Text = "Manifest generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scenCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatedValuesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxDuration;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown scenCount;
        private System.Windows.Forms.TextBox maxMark;
        private System.Windows.Forms.TextBox passMark;
        private System.Windows.Forms.DataGridView updatedValuesGrid;
        private System.Windows.Forms.Label labelMaxDuration;
        private System.Windows.Forms.Label labelMaxMark;
        private System.Windows.Forms.Label defaultPassMark;
        private System.Windows.Forms.Label sceneCount;
        private System.Windows.Forms.Button defaultPassMarkApply;
        private System.Windows.Forms.Button defaultMaxMarkApply;
        private System.Windows.Forms.Button defaultMaxDurationApply;
        private System.Windows.Forms.Button browseDirectory;
        private System.Windows.Forms.Label directoryInfo;
    }
}

