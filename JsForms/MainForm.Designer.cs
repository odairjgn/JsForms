namespace JsForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            txtJs = new TextBox();
            btExec = new Button();
            lkHelp = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "JavaScript:";
            // 
            // txtJs
            // 
            txtJs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtJs.Location = new Point(9, 30);
            txtJs.Multiline = true;
            txtJs.Name = "txtJs";
            txtJs.ScrollBars = ScrollBars.Both;
            txtJs.Size = new Size(779, 379);
            txtJs.TabIndex = 1;
            txtJs.Text = resources.GetString("txtJs.Text");
            // 
            // btExec
            // 
            btExec.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btExec.Location = new Point(713, 415);
            btExec.Name = "btExec";
            btExec.Size = new Size(75, 23);
            btExec.TabIndex = 2;
            btExec.Text = "Executar";
            btExec.UseVisualStyleBackColor = true;
            btExec.Click += btExec_Click;
            // 
            // lkHelp
            // 
            lkHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lkHelp.AutoSize = true;
            lkHelp.Location = new Point(15, 424);
            lkHelp.Name = "lkHelp";
            lkHelp.Size = new Size(38, 15);
            lkHelp.TabIndex = 3;
            lkHelp.TabStop = true;
            lkHelp.Text = "Ajuda";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lkHelp);
            Controls.Add(btExec);
            Controls.Add(txtJs);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtJs;
        private Button btExec;
        private LinkLabel lkHelp;
    }
}