namespace Daily_Logger;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        tableLayoutPanel1 = new TableLayoutPanel();
        txtLogEntry = new TextBox();
        btnSave = new Button();
        tabPage2 = new TabPage();
        tableLayoutPanel2 = new TableLayoutPanel();
        txtKeyword = new TextBox();
        treeHistory = new TreeView();
        contextMenuStrip1 = new ContextMenuStrip(components);
        addUpdatesToolStripMenuItem = new ToolStripMenuItem();
        exportLogToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        deleteLogToolStripMenuItem = new ToolStripMenuItem();
        txtHistory = new TextBox();
        lblLogTitle = new Label();
        notification = new NotifyIcon(components);
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tabPage2.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        contextMenuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Appearance = TabAppearance.FlatButtons;
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.HotTrack = true;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Multiline = true;
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(618, 450);
        tabControl1.SizeMode = TabSizeMode.Fixed;
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.AutoScroll = true;
        tabPage1.BackColor = SystemColors.ActiveBorder;
        tabPage1.BorderStyle = BorderStyle.Fixed3D;
        tabPage1.Controls.Add(tableLayoutPanel1);
        tabPage1.Font = new Font("Noto Sans Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
        tabPage1.Location = new Point(4, 27);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(610, 419);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "New Log Entry";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(txtLogEntry, 0, 0);
        tableLayoutPanel1.Controls.Add(btnSave, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.Size = new Size(600, 409);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // txtLogEntry
        // 
        txtLogEntry.Dock = DockStyle.Fill;
        txtLogEntry.Location = new Point(3, 3);
        txtLogEntry.Multiline = true;
        txtLogEntry.Name = "txtLogEntry";
        txtLogEntry.Size = new Size(594, 362);
        txtLogEntry.TabIndex = 0;
        // 
        // btnSave
        // 
        btnSave.AutoSize = true;
        btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnSave.BackColor = Color.Snow;
        btnSave.Dock = DockStyle.Right;
        btnSave.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
        btnSave.FlatAppearance.MouseDownBackColor = Color.Lime;
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
        btnSave.FlatStyle = FlatStyle.Popup;
        btnSave.Font = new Font("Noto Sans", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
        btnSave.ForeColor = SystemColors.ActiveCaptionText;
        btnSave.Location = new Point(512, 371);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(85, 35);
        btnSave.TabIndex = 1;
        btnSave.Text = "Save Log";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // tabPage2
        // 
        tabPage2.BorderStyle = BorderStyle.Fixed3D;
        tabPage2.Controls.Add(tableLayoutPanel2);
        tabPage2.Font = new Font("Noto Sans Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
        tabPage2.Location = new Point(4, 27);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(610, 419);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "History";
        tabPage2.UseVisualStyleBackColor = true;
        tabPage2.Enter += TabPage2_Enter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        tableLayoutPanel2.Controls.Add(txtKeyword, 0, 0);
        tableLayoutPanel2.Controls.Add(treeHistory, 0, 1);
        tableLayoutPanel2.Controls.Add(txtHistory, 1, 1);
        tableLayoutPanel2.Controls.Add(lblLogTitle, 1, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
        tableLayoutPanel2.Size = new Size(600, 409);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // txtKeyword
        // 
        txtKeyword.BackColor = SystemColors.InactiveBorder;
        txtKeyword.Dock = DockStyle.Fill;
        txtKeyword.Enabled = false;
        txtKeyword.Location = new Point(3, 3);
        txtKeyword.MaxLength = 250;
        txtKeyword.Name = "txtKeyword";
        txtKeyword.PlaceholderText = "Search (Currently Unavailable)";
        txtKeyword.Size = new Size(174, 24);
        txtKeyword.TabIndex = 0;
        // 
        // treeHistory
        // 
        treeHistory.BackColor = SystemColors.Menu;
        treeHistory.ContextMenuStrip = contextMenuStrip1;
        treeHistory.Dock = DockStyle.Fill;
        treeHistory.Location = new Point(3, 35);
        treeHistory.Name = "treeHistory";
        treeHistory.Size = new Size(174, 371);
        treeHistory.TabIndex = 1;
        treeHistory.AfterSelect += TreeHistory_AfterSelect;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addUpdatesToolStripMenuItem, exportLogToolStripMenuItem, toolStripSeparator1, deleteLogToolStripMenuItem });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(138, 76);
        // 
        // addUpdatesToolStripMenuItem
        // 
        addUpdatesToolStripMenuItem.Name = "addUpdatesToolStripMenuItem";
        addUpdatesToolStripMenuItem.Size = new Size(137, 22);
        addUpdatesToolStripMenuItem.Text = "Add Update";
        addUpdatesToolStripMenuItem.Click += addUpdatesToolStripMenuItem_Click;
        // 
        // exportLogToolStripMenuItem
        // 
        exportLogToolStripMenuItem.Name = "exportLogToolStripMenuItem";
        exportLogToolStripMenuItem.Size = new Size(137, 22);
        exportLogToolStripMenuItem.Text = "Export Log";
        exportLogToolStripMenuItem.Click += exportLogToolStripMenuItem_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(134, 6);
        // 
        // deleteLogToolStripMenuItem
        // 
        deleteLogToolStripMenuItem.Name = "deleteLogToolStripMenuItem";
        deleteLogToolStripMenuItem.Size = new Size(137, 22);
        deleteLogToolStripMenuItem.Text = "Delete Log";
        deleteLogToolStripMenuItem.Click += deleteLogToolStripMenuItem_Click;
        // 
        // txtHistory
        // 
        txtHistory.BorderStyle = BorderStyle.None;
        txtHistory.Dock = DockStyle.Fill;
        txtHistory.Font = new Font("Noto Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtHistory.Location = new Point(183, 35);
        txtHistory.Multiline = true;
        txtHistory.Name = "txtHistory";
        txtHistory.ReadOnly = true;
        txtHistory.Size = new Size(414, 371);
        txtHistory.TabIndex = 2;
        // 
        // lblLogTitle
        // 
        lblLogTitle.AutoSize = true;
        lblLogTitle.Dock = DockStyle.Fill;
        lblLogTitle.Font = new Font("Noto Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
        lblLogTitle.Location = new Point(183, 0);
        lblLogTitle.Name = "lblLogTitle";
        lblLogTitle.Size = new Size(414, 32);
        lblLogTitle.TabIndex = 3;
        lblLogTitle.Text = "Selected Log Title";
        lblLogTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // notification
        // 
        notification.Text = "notifyIcon1";
        notification.Visible = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        ClientSize = new Size(618, 450);
        Controls.Add(tabControl1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MainForm";
        Text = "Daily Logger";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tabPage2.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        contextMenuStrip1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private void TreeHistory_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (treeHistory.SelectedNode != null && treeHistory.SelectedNode.Parent != null)
        {
            string logTitle = treeHistory.SelectedNode.Parent.Text;
            string logEntry = treeHistory.SelectedNode.Text;
            logEntry = logEntry.Replace("\\r\\n", Environment.NewLine);
            txtHistory.Text = logEntry;
            lblLogTitle.Text = logTitle;
        }
    }



    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TableLayoutPanel tableLayoutPanel1;
    private TextBox txtLogEntry;
    private Button btnSave;
    private TableLayoutPanel tableLayoutPanel2;
    private TextBox txtKeyword;
    private TreeView treeHistory;
    private TextBox txtHistory;
    private Label lblLogTitle;
    private NotifyIcon notification;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem addUpdatesToolStripMenuItem;
    private ToolStripMenuItem exportLogToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem deleteLogToolStripMenuItem;
}
