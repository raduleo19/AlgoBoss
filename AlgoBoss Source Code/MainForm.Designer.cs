namespace WindowsFormsApplication4
{
    partial class Grafuri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafuri));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Base = new WindowsFormsApplication4.Canvas2();
            this.Liste = new WindowsFormsApplication4.Canvas2();
            this.webView3 = new Microsoft.Toolkit.Win32.UI.Controls.WinForms.WebView();
            this.Sort = new WindowsFormsApplication4.Canvas2();
            this.webView2 = new Microsoft.Toolkit.Win32.UI.Controls.WinForms.WebView();
            this.Ide = new WindowsFormsApplication4.Canvas2();
            this.webView1 = new Microsoft.Toolkit.Win32.UI.Controls.WinForms.WebView();
            this.meniu1 = new WindowsFormsApplication4.Canvas2();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.ExPanel = new WindowsFormsApplication4.Canvas2();
            this.button17 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Examples = new WindowsFormsApplication4.Canvas2();
            this.SaveTo = new System.Windows.Forms.Button();
            this.AlgoSel = new System.Windows.Forms.ComboBox();
            this.GraphEditorPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mySeparator3 = new WindowsFormsApplication4.MySeparator();
            this.mySeparator2 = new WindowsFormsApplication4.MySeparator();
            this.AddEdgeButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.QueuePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StartingPoint = new System.Windows.Forms.TextBox();
            this.AlgoList = new System.Windows.Forms.ComboBox();
            this.Reset = new System.Windows.Forms.Button();
            this.panel2 = new WindowsFormsApplication4.Canvas2();
            this.Pause = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RemoveEdge = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Simulate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.RemoveNode = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddNode = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMax1 = new FlatUI.FlatMax();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.Scorebar = new WindowsFormsApplication4.MyProgressBar2();
            this.TProg = new WindowsFormsApplication4.MyProgressBar2();
            this.ProgresT = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Ceas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loading = new WindowsFormsApplication4.Canvas2();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.flatMini3 = new FlatUI.FlatMini();
            this.flatClose3 = new FlatUI.FlatClose();
            this.flatMax3 = new FlatUI.FlatMax();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.Base.SuspendLayout();
            this.Liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView3)).BeginInit();
            this.Sort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.Ide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.meniu1.SuspendLayout();
            this.ExPanel.SuspendLayout();
            this.Examples.SuspendLayout();
            this.GraphEditorPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Header.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Logo.SuspendLayout();
            this.Loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Base
            // 
            this.Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Base.Controls.Add(this.Liste);
            this.Base.Controls.Add(this.Sort);
            this.Base.Controls.Add(this.Ide);
            this.Base.Controls.Add(this.meniu1);
            this.Base.Controls.Add(this.ExPanel);
            this.Base.Controls.Add(this.Examples);
            this.Base.Controls.Add(this.GraphEditorPanel);
            this.Base.Controls.Add(this.Header);
            this.Base.Controls.Add(this.Sidebar);
            this.Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base.Location = new System.Drawing.Point(0, 0);
            this.Base.Margin = new System.Windows.Forms.Padding(4);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(1707, 886);
            this.Base.TabIndex = 66;
            // 
            // Liste
            // 
            this.Liste.Controls.Add(this.webView3);
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(280, 63);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1425, 821);
            this.Liste.TabIndex = 1;
            // 
            // webView3
            // 
            this.webView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView3.Location = new System.Drawing.Point(0, 0);
            this.webView3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView3.Name = "webView3";
            this.webView3.Size = new System.Drawing.Size(1425, 821);
            this.webView3.Source = new System.Uri("https://visualgo.net/en/list", System.UriKind.Absolute);
            this.webView3.TabIndex = 0;
            // 
            // Sort
            // 
            this.Sort.Controls.Add(this.webView2);
            this.Sort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sort.Location = new System.Drawing.Point(280, 63);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(1425, 821);
            this.Sort.TabIndex = 1;
            // 
            // webView2
            // 
            this.webView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView2.Location = new System.Drawing.Point(0, 0);
            this.webView2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(1425, 821);
            this.webView2.Source = new System.Uri("https://visualgo.net/en/sorting", System.UriKind.Absolute);
            this.webView2.TabIndex = 0;
            // 
            // Ide
            // 
            this.Ide.Controls.Add(this.webView1);
            this.Ide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ide.Location = new System.Drawing.Point(280, 63);
            this.Ide.Name = "Ide";
            this.Ide.Size = new System.Drawing.Size(1425, 821);
            this.Ide.TabIndex = 7;
            // 
            // webView1
            // 
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(1425, 821);
            this.webView1.Source = new System.Uri("http://repl.it", System.UriKind.Absolute);
            this.webView1.TabIndex = 0;
            // 
            // meniu1
            // 
            this.meniu1.BackColor = System.Drawing.Color.White;
            this.meniu1.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources._1;
            this.meniu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.meniu1.Controls.Add(this.button11);
            this.meniu1.Controls.Add(this.button10);
            this.meniu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meniu1.Location = new System.Drawing.Point(280, 63);
            this.meniu1.Margin = new System.Windows.Forms.Padding(4);
            this.meniu1.Name = "meniu1";
            this.meniu1.Size = new System.Drawing.Size(1425, 821);
            this.meniu1.TabIndex = 64;
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.Dock = System.Windows.Forms.DockStyle.Right;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(1325, 0);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 821);
            this.button11.TabIndex = 6;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.Dock = System.Windows.Forms.DockStyle.Left;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 821);
            this.button10.TabIndex = 5;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // ExPanel
            // 
            this.ExPanel.BackColor = System.Drawing.Color.White;
            this.ExPanel.Controls.Add(this.button17);
            this.ExPanel.Controls.Add(this.flowLayoutPanel1);
            this.ExPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExPanel.Location = new System.Drawing.Point(280, 63);
            this.ExPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ExPanel.Name = "ExPanel";
            this.ExPanel.Size = new System.Drawing.Size(1425, 821);
            this.ExPanel.TabIndex = 7;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(1114, 666);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(251, 50);
            this.button17.TabIndex = 1;
            this.button17.Text = "Verifica";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(57, 37);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1308, 574);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Examples
            // 
            this.Examples.BackColor = System.Drawing.Color.White;
            this.Examples.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Examples.BackgroundImage")));
            this.Examples.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Examples.Controls.Add(this.SaveTo);
            this.Examples.Controls.Add(this.AlgoSel);
            this.Examples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Examples.Location = new System.Drawing.Point(280, 63);
            this.Examples.Margin = new System.Windows.Forms.Padding(4);
            this.Examples.Name = "Examples";
            this.Examples.Size = new System.Drawing.Size(1425, 821);
            this.Examples.TabIndex = 7;
            // 
            // SaveTo
            // 
            this.SaveTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.SaveTo.FlatAppearance.BorderSize = 0;
            this.SaveTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTo.ForeColor = System.Drawing.Color.Black;
            this.SaveTo.Location = new System.Drawing.Point(57, 180);
            this.SaveTo.Margin = new System.Windows.Forms.Padding(4);
            this.SaveTo.Name = "SaveTo";
            this.SaveTo.Size = new System.Drawing.Size(452, 49);
            this.SaveTo.TabIndex = 45;
            this.SaveTo.Text = "Salveaza sursa";
            this.SaveTo.UseVisualStyleBackColor = false;
            this.SaveTo.Click += new System.EventHandler(this.SaveTo_Click);
            // 
            // AlgoSel
            // 
            this.AlgoSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.AlgoSel.CausesValidation = false;
            this.AlgoSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgoSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgoSel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgoSel.ForeColor = System.Drawing.Color.Black;
            this.AlgoSel.FormattingEnabled = true;
            this.AlgoSel.ItemHeight = 31;
            this.AlgoSel.Items.AddRange(new object[] {
            "Breadth-first search",
            "Depth-first search",
            "Bellman–Ford algorithm",
            "Dijkstra\'s algorithm",
            "Kruskal\'s algorithm",
            "Prim\'s algorithm",
            "Kosaraju\'s algorithm",
            "Tarjan\'s strongly connected components algorithm",
            "Biconnected Components",
            "Hamiltonian Cycle",
            "Eulerian Cycle",
            "Edmonds-Karp Max Flow",
            "Hopcroft Karp bipartite matching"});
            this.AlgoSel.Location = new System.Drawing.Point(57, 123);
            this.AlgoSel.Margin = new System.Windows.Forms.Padding(4);
            this.AlgoSel.Name = "AlgoSel";
            this.AlgoSel.Size = new System.Drawing.Size(743, 39);
            this.AlgoSel.TabIndex = 44;
            this.AlgoSel.DropDownClosed += new System.EventHandler(this.AlgoList_DropDownClosed);
            // 
            // GraphEditorPanel
            // 
            this.GraphEditorPanel.BackColor = System.Drawing.Color.White;
            this.GraphEditorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GraphEditorPanel.Controls.Add(this.label9);
            this.GraphEditorPanel.Controls.Add(this.label6);
            this.GraphEditorPanel.Controls.Add(this.mySeparator3);
            this.GraphEditorPanel.Controls.Add(this.mySeparator2);
            this.GraphEditorPanel.Controls.Add(this.AddEdgeButton);
            this.GraphEditorPanel.Controls.Add(this.Clear);
            this.GraphEditorPanel.Controls.Add(this.QueuePanel);
            this.GraphEditorPanel.Controls.Add(this.panel4);
            this.GraphEditorPanel.Controls.Add(this.AlgoList);
            this.GraphEditorPanel.Controls.Add(this.Reset);
            this.GraphEditorPanel.Controls.Add(this.panel2);
            this.GraphEditorPanel.Controls.Add(this.Pause);
            this.GraphEditorPanel.Controls.Add(this.checkBox3);
            this.GraphEditorPanel.Controls.Add(this.textBox1);
            this.GraphEditorPanel.Controls.Add(this.RemoveEdge);
            this.GraphEditorPanel.Controls.Add(this.textBox5);
            this.GraphEditorPanel.Controls.Add(this.checkBox2);
            this.GraphEditorPanel.Controls.Add(this.Simulate);
            this.GraphEditorPanel.Controls.Add(this.label4);
            this.GraphEditorPanel.Controls.Add(this.label3);
            this.GraphEditorPanel.Controls.Add(this.textBox4);
            this.GraphEditorPanel.Controls.Add(this.textBox3);
            this.GraphEditorPanel.Controls.Add(this.checkBox1);
            this.GraphEditorPanel.Controls.Add(this.RemoveNode);
            this.GraphEditorPanel.Controls.Add(this.textBox2);
            this.GraphEditorPanel.Controls.Add(this.AddNode);
            this.GraphEditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphEditorPanel.Location = new System.Drawing.Point(280, 63);
            this.GraphEditorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GraphEditorPanel.Name = "GraphEditorPanel";
            this.GraphEditorPanel.Size = new System.Drawing.Size(1425, 821);
            this.GraphEditorPanel.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 714);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 32);
            this.label9.TabIndex = 61;
            this.label9.Text = "Cost:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 666);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 32);
            this.label6.TabIndex = 60;
            this.label6.Text = "Coada:";
            // 
            // mySeparator3
            // 
            this.mySeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mySeparator3.BackColor = System.Drawing.Color.Transparent;
            this.mySeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.mySeparator3.LineThickness = 2;
            this.mySeparator3.Location = new System.Drawing.Point(1056, 452);
            this.mySeparator3.Margin = new System.Windows.Forms.Padding(5);
            this.mySeparator3.Name = "mySeparator3";
            this.mySeparator3.Size = new System.Drawing.Size(325, 21);
            this.mySeparator3.TabIndex = 59;
            this.mySeparator3.Transparency = 255;
            this.mySeparator3.Vertical = false;
            // 
            // mySeparator2
            // 
            this.mySeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mySeparator2.BackColor = System.Drawing.Color.Transparent;
            this.mySeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.mySeparator2.LineThickness = 2;
            this.mySeparator2.Location = new System.Drawing.Point(1056, 235);
            this.mySeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.mySeparator2.Name = "mySeparator2";
            this.mySeparator2.Size = new System.Drawing.Size(325, 21);
            this.mySeparator2.TabIndex = 58;
            this.mySeparator2.Transparency = 255;
            this.mySeparator2.Vertical = false;
            // 
            // AddEdgeButton
            // 
            this.AddEdgeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEdgeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.AddEdgeButton.FlatAppearance.BorderSize = 0;
            this.AddEdgeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.AddEdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEdgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEdgeButton.ForeColor = System.Drawing.Color.White;
            this.AddEdgeButton.Location = new System.Drawing.Point(1234, 388);
            this.AddEdgeButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddEdgeButton.Name = "AddEdgeButton";
            this.AddEdgeButton.Size = new System.Drawing.Size(147, 59);
            this.AddEdgeButton.TabIndex = 56;
            this.AddEdgeButton.Text = "Adauga Muchie";
            this.AddEdgeButton.UseVisualStyleBackColor = false;
            this.AddEdgeButton.Click += new System.EventHandler(this.AddEdge_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(1056, 730);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(325, 52);
            this.Clear.TabIndex = 55;
            this.Clear.Text = "Sterge Graf";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.ClearGraphControl);
            // 
            // QueuePanel
            // 
            this.QueuePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueuePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.QueuePanel.ColumnCount = 68;
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.QueuePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.QueuePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.QueuePanel.Location = new System.Drawing.Point(125, 658);
            this.QueuePanel.Margin = new System.Windows.Forms.Padding(0);
            this.QueuePanel.Name = "QueuePanel";
            this.QueuePanel.RowCount = 1;
            this.QueuePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QueuePanel.Size = new System.Drawing.Size(922, 39);
            this.QueuePanel.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.StartingPoint);
            this.panel4.Location = new System.Drawing.Point(1245, 534);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 46);
            this.panel4.TabIndex = 50;
            // 
            // StartingPoint
            // 
            this.StartingPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartingPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.StartingPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartingPoint.ForeColor = System.Drawing.Color.White;
            this.StartingPoint.Location = new System.Drawing.Point(25, 16);
            this.StartingPoint.Margin = new System.Windows.Forms.Padding(4);
            this.StartingPoint.Name = "StartingPoint";
            this.StartingPoint.Size = new System.Drawing.Size(84, 15);
            this.StartingPoint.TabIndex = 37;
            this.StartingPoint.Text = "Start";
            this.StartingPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartingPoint.Click += new System.EventHandler(this.StartingPoint_Click);
            // 
            // AlgoList
            // 
            this.AlgoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlgoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.AlgoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgoList.ForeColor = System.Drawing.Color.White;
            this.AlgoList.FormattingEnabled = true;
            this.AlgoList.Items.AddRange(new object[] {
            "Breadth-first search",
            "Depth-first search",
            "[WIP]Bellman–Ford algorithm",
            "[WIP]Dijkstra\'s algorithm",
            "Kruskal\'s algorithm",
            "[WIP]Prim\'s algorithm",
            "[WIP]Kosaraju\'s algorithm",
            "[WIP]Tarjan\'s strongly connected components algorithm",
            "[WIP]Biconnected Components",
            "[WIP]Eulerian Cycle",
            "[WIP]Hamiltonian Cycle",
            "[WIP]Edmonds-Karp Max Flow",
            "[WIP]Hopcroft Karp bipartite matching"});
            this.AlgoList.Location = new System.Drawing.Point(1056, 501);
            this.AlgoList.Margin = new System.Windows.Forms.Padding(4);
            this.AlgoList.Name = "AlgoList";
            this.AlgoList.Size = new System.Drawing.Size(324, 24);
            this.AlgoList.TabIndex = 43;
            this.AlgoList.SelectionChangeCommitted += new System.EventHandler(this.AlgoList_SelectionChangeCommitted);
            this.AlgoList.DropDownClosed += new System.EventHandler(this.AlgoList_DropDownClosed);
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.Reset.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(1056, 671);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(325, 52);
            this.Reset.TabIndex = 42;
            this.Reset.Text = "Reseteaza Date Graf";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(37, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 536);
            this.panel2.TabIndex = 39;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawEdges);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // Pause
            // 
            this.Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.Color.Black;
            this.Pause.Location = new System.Drawing.Point(1056, 534);
            this.Pause.Margin = new System.Windows.Forms.Padding(4);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(177, 47);
            this.Pause.TabIndex = 38;
            this.Pause.Text = "Pauza";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox3.Location = new System.Drawing.Point(1242, 319);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 21);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.Text = "Network";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1234, 347);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "Capacity";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.button6_Click);
            // 
            // RemoveEdge
            // 
            this.RemoveEdge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.RemoveEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEdge.ForeColor = System.Drawing.Color.White;
            this.RemoveEdge.Location = new System.Drawing.Point(1056, 388);
            this.RemoveEdge.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveEdge.Name = "RemoveEdge";
            this.RemoveEdge.Size = new System.Drawing.Size(147, 59);
            this.RemoveEdge.TabIndex = 34;
            this.RemoveEdge.Text = "Sterge Muchie";
            this.RemoveEdge.UseVisualStyleBackColor = false;
            this.RemoveEdge.Click += new System.EventHandler(this.RemoveEdge_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(1056, 347);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 22);
            this.textBox5.TabIndex = 29;
            this.textBox5.Text = "Cost";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox2.Location = new System.Drawing.Point(1062, 319);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 21);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Weighted";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Simulate
            // 
            this.Simulate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Simulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Simulate.FlatAppearance.BorderSize = 0;
            this.Simulate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.Simulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Simulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simulate.ForeColor = System.Drawing.Color.White;
            this.Simulate.Location = new System.Drawing.Point(1056, 590);
            this.Simulate.Margin = new System.Windows.Forms.Padding(4);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(325, 74);
            this.Simulate.TabIndex = 26;
            this.Simulate.Text = "Simuleaza Algoritm";
            this.Simulate.UseVisualStyleBackColor = false;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1056, 471);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Algorithms:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1205, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "<->";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(1234, 281);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 22);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Finish";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(1056, 281);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 22);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "Start";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.Location = new System.Drawing.Point(1059, 252);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Oriented";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RemoveNode
            // 
            this.RemoveNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.RemoveNode.FlatAppearance.BorderSize = 0;
            this.RemoveNode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.RemoveNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveNode.ForeColor = System.Drawing.Color.White;
            this.RemoveNode.Location = new System.Drawing.Point(1225, 137);
            this.RemoveNode.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveNode.Name = "RemoveNode";
            this.RemoveNode.Size = new System.Drawing.Size(156, 91);
            this.RemoveNode.TabIndex = 17;
            this.RemoveNode.Text = "Sterge Nod";
            this.RemoveNode.UseVisualStyleBackColor = false;
            this.RemoveNode.Click += new System.EventHandler(this.RemoveNode_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(1225, 105);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Node to remove";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // AddNode
            // 
            this.AddNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.AddNode.FlatAppearance.BorderSize = 0;
            this.AddNode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.AddNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNode.ForeColor = System.Drawing.Color.White;
            this.AddNode.Location = new System.Drawing.Point(1056, 105);
            this.AddNode.Margin = new System.Windows.Forms.Padding(4);
            this.AddNode.Name = "AddNode";
            this.AddNode.Size = new System.Drawing.Size(147, 123);
            this.AddNode.TabIndex = 15;
            this.AddNode.Text = "Adauga Nod";
            this.AddNode.UseVisualStyleBackColor = false;
            this.AddNode.Click += new System.EventHandler(this.AddNode_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.flatMini1);
            this.Header.Controls.Add(this.flatClose1);
            this.Header.Controls.Add(this.flatMax1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(280, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1425, 63);
            this.Header.TabIndex = 57;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.Blue;
            this.flatMini1.BaseColor = System.Drawing.Color.White;
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(1310, 20);
            this.flatMini1.Margin = new System.Windows.Forms.Padding(4);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 13;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.White;
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(1374, 20);
            this.flatClose1.Margin = new System.Windows.Forms.Padding(4);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 12;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.White;
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(1342, 20);
            this.flatMax1.Margin = new System.Windows.Forms.Padding(4);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 11;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Sidebar.Controls.Add(this.panel3);
            this.Sidebar.Controls.Add(this.Logo);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(280, 884);
            this.Sidebar.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 208);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 676);
            this.panel3.TabIndex = 69;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(8, 105);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(265, 41);
            this.button5.TabIndex = 48;
            this.button5.Text = "ListeStiveCozi";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(8, 329);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 41);
            this.button3.TabIndex = 47;
            this.button3.Text = "IDE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(10, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 41);
            this.button2.TabIndex = 46;
            this.button2.Text = "SortSimulator";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(85, 625);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Autor: Rica Radu";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(97, 604);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Versiunea 1.2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(8, 56);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(265, 41);
            this.button14.TabIndex = 16;
            this.button14.Text = "Exemple de surse";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button2_Click);
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.button14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.electronic_brain_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(69, 478);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(8, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Teorie";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Verificarea cunostintelor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(10, 208);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(265, 41);
            this.button6.TabIndex = 10;
            this.button6.Text = "GraphSimulator";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.button6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Logo.Controls.Add(this.Scorebar);
            this.Logo.Controls.Add(this.TProg);
            this.Logo.Controls.Add(this.ProgresT);
            this.Logo.Controls.Add(this.label13);
            this.Logo.Controls.Add(this.Ceas);
            this.Logo.Controls.Add(this.label12);
            this.Logo.Controls.Add(this.label1);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(280, 208);
            this.Logo.TabIndex = 63;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.Logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // Scorebar
            // 
            this.Scorebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Scorebar.BorderRadius = 0;
            this.Scorebar.Location = new System.Drawing.Point(7, 161);
            this.Scorebar.Margin = new System.Windows.Forms.Padding(5);
            this.Scorebar.MaximumValue = 100;
            this.Scorebar.Name = "Scorebar";
            this.Scorebar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.Scorebar.Size = new System.Drawing.Size(259, 21);
            this.Scorebar.TabIndex = 26;
            this.Scorebar.Value = 0;
            // 
            // TProg
            // 
            this.TProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.TProg.BorderRadius = 0;
            this.TProg.Location = new System.Drawing.Point(7, 100);
            this.TProg.Margin = new System.Windows.Forms.Padding(5);
            this.TProg.MaximumValue = 5;
            this.TProg.Name = "TProg";
            this.TProg.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.TProg.Size = new System.Drawing.Size(259, 21);
            this.TProg.TabIndex = 8;
            this.TProg.Value = 1;
            // 
            // ProgresT
            // 
            this.ProgresT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgresT.ForeColor = System.Drawing.Color.White;
            this.ProgresT.Location = new System.Drawing.Point(171, 63);
            this.ProgresT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgresT.Name = "ProgresT";
            this.ProgresT.Size = new System.Drawing.Size(95, 26);
            this.ProgresT.TabIndex = 25;
            this.ProgresT.Text = "0";
            this.ProgresT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(176, 132);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 26);
            this.label13.TabIndex = 24;
            this.label13.Text = "0";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ceas
            // 
            this.Ceas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ceas.ForeColor = System.Drawing.Color.White;
            this.Ceas.Location = new System.Drawing.Point(91, 23);
            this.Ceas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ceas.Name = "Ceas";
            this.Ceas.Size = new System.Drawing.Size(111, 34);
            this.Ceas.TabIndex = 18;
            this.Ceas.Text = "Clock";
            this.Ceas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 28);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nota maxima:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Teorie Parcursa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loading
            // 
            this.Loading.BackColor = System.Drawing.Color.White;
            this.Loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loading.Controls.Add(this.label8);
            this.Loading.Controls.Add(this.pictureBox5);
            this.Loading.Controls.Add(this.flatMini3);
            this.Loading.Controls.Add(this.flatClose3);
            this.Loading.Controls.Add(this.flatMax3);
            this.Loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading.Location = new System.Drawing.Point(0, 0);
            this.Loading.Margin = new System.Windows.Forms.Padding(4);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(1707, 886);
            this.Loading.TabIndex = 33;
            this.Loading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.Loading.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.Loading.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(821, 597);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Loading...";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.ImageLocation = "Data/Loading.gif";
            this.pictureBox5.Location = new System.Drawing.Point(0, 74);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1707, 266);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_mouseDown);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_mouseMove);
            this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_mouseUp);
            // 
            // flatMini3
            // 
            this.flatMini3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini3.BackColor = System.Drawing.Color.Blue;
            this.flatMini3.BaseColor = System.Drawing.Color.White;
            this.flatMini3.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini3.Location = new System.Drawing.Point(1584, 16);
            this.flatMini3.Margin = new System.Windows.Forms.Padding(4);
            this.flatMini3.Name = "flatMini3";
            this.flatMini3.Size = new System.Drawing.Size(18, 18);
            this.flatMini3.TabIndex = 19;
            this.flatMini3.Text = "flatMini3";
            this.flatMini3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // flatClose3
            // 
            this.flatClose3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose3.BackColor = System.Drawing.Color.White;
            this.flatClose3.BaseColor = System.Drawing.Color.White;
            this.flatClose3.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose3.Location = new System.Drawing.Point(1653, 16);
            this.flatClose3.Margin = new System.Windows.Forms.Padding(4);
            this.flatClose3.Name = "flatClose3";
            this.flatClose3.Size = new System.Drawing.Size(18, 18);
            this.flatClose3.TabIndex = 18;
            this.flatClose3.Text = "flatClose3";
            this.flatClose3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // flatMax3
            // 
            this.flatMax3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax3.BackColor = System.Drawing.Color.White;
            this.flatMax3.BaseColor = System.Drawing.Color.White;
            this.flatMax3.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax3.Location = new System.Drawing.Point(1621, 16);
            this.flatMax3.Margin = new System.Windows.Forms.Padding(4);
            this.flatMax3.Name = "flatMax3";
            this.flatMax3.Size = new System.Drawing.Size(18, 18);
            this.flatMax3.TabIndex = 17;
            this.flatMax3.Text = "flatMax3";
            this.flatMax3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // Grafuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.Loading);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grafuri";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafuri";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.Base.ResumeLayout(false);
            this.Liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView3)).EndInit();
            this.Sort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.Ide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.meniu1.ResumeLayout(false);
            this.ExPanel.ResumeLayout(false);
            this.Examples.ResumeLayout(false);
            this.GraphEditorPanel.ResumeLayout(false);
            this.GraphEditorPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            this.Loading.ResumeLayout(false);
            this.Loading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AddNode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button RemoveNode;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button RemoveEdge;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button Pause;
        private Canvas2 panel2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ComboBox AlgoList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox StartingPoint;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button AddEdgeButton;
        private System.Windows.Forms.Panel GraphEditorPanel;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ceas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ProgresT;
        private Canvas2 meniu1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private MyProgressBar2 Scorebar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MySeparator mySeparator3;
        private MySeparator mySeparator2;
        private Canvas2 Examples;
        private System.Windows.Forms.Button SaveTo;
        private System.Windows.Forms.ComboBox AlgoSel;
        private System.Windows.Forms.Button button14;
        private Canvas2 ExPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TableLayoutPanel QueuePanel;
        private Canvas2 Base;
        private System.Windows.Forms.Panel Header;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMax flatMax1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Canvas2 Loading;
        private FlatUI.FlatMini flatMini3;
        private FlatUI.FlatClose flatClose3;
        private FlatUI.FlatMax flatMax3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private MyProgressBar2 TProg;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Canvas2 Ide;
        private Microsoft.Toolkit.Win32.UI.Controls.WinForms.WebView webView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Canvas2 Sort;
        private Microsoft.Toolkit.Win32.UI.Controls.WinForms.WebView webView2;
        private Canvas2 Liste;
        private Microsoft.Toolkit.Win32.UI.Controls.WinForms.WebView webView3;
        private System.Windows.Forms.Button button5;
    }
}

