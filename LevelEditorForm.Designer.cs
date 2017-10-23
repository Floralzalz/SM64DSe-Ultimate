﻿using OpenTK.Graphics;
namespace SM64DSe
{
    partial class LevelEditorForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelEditorForm));
            this.spcMainContainer = new System.Windows.Forms.SplitContainer();
            this.spcLeftPanel = new System.Windows.Forms.SplitContainer();
            this.tvObjectList = new System.Windows.Forms.TreeView();
            this.btnCopyCoordinates = new System.Windows.Forms.Button();
            this.pgObjectProperties = new System.Windows.Forms.PropertyGrid();
            this.tsEditActions = new System.Windows.Forms.ToolStrip();
            this.btnImportModel = new System.Windows.Forms.ToolStripButton();
            this.btnExportLevelModel = new System.Windows.Forms.ToolStripButton();
            this.btnAddObject = new System.Windows.Forms.ToolStripButton();
            this.btnAddWarp = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddEntrance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAreaWarp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTpSrc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTpDst = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddView = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveSel = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveAll = new System.Windows.Forms.ToolStripButton();
            this.btnReplaceObjModel = new System.Windows.Forms.ToolStripButton();
            this.btnExportObjectModel = new System.Windows.Forms.ToolStripButton();
            this.btnAddPathNodes = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddPath = new System.Windows.Forms.ToolStripButton();
            this.btnAddMisc = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportOtherModel = new System.Windows.Forms.ToolStripButton();
            this.btnExportOtherModel = new System.Windows.Forms.ToolStripButton();
            this.btnOffsetAllCoords = new System.Windows.Forms.ToolStripButton();
            this.glLevelView = new OpenTK.GLControl();
            this.tsViewActions = new System.Windows.Forms.ToolStrip();
            this.btnLOL = new System.Windows.Forms.ToolStripButton();
            this.btnImportXML = new System.Windows.Forms.ToolStripButton();
            this.btnExportXML = new System.Windows.Forms.ToolStripButton();
            this.btnScreenshot = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOrthView = new System.Windows.Forms.ToolStripButton();
            this.menuGridSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.txtGridSizeX = new System.Windows.Forms.ToolStripTextBox();
            this.txtGridSizeY = new System.Windows.Forms.ToolStripTextBox();
            this.txtGridSizeZ = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txtGridOffsetX = new System.Windows.Forms.ToolStripTextBox();
            this.txtGridOffsetY = new System.Windows.Forms.ToolStripTextBox();
            this.txtGridOffsetZ = new System.Windows.Forms.ToolStripTextBox();
            this.menuRestrictionPlane = new System.Windows.Forms.ToolStripDropDownButton();
            this.txtRstPlaneX = new System.Windows.Forms.ToolStripTextBox();
            this.txtRstPlaneY = new System.Windows.Forms.ToolStripTextBox();
            this.txtRstPlaneZ = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.txtRstPlaneOffX = new System.Windows.Forms.ToolStripTextBox();
            this.txtRstPlaneOffY = new System.Windows.Forms.ToolStripTextBox();
            this.txtRstPlaneOffZ = new System.Windows.Forms.ToolStripTextBox();
            this.btnMakeOverlay = new System.Windows.Forms.ToolStripButton();
            this.tsToolBar = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLevelSettings = new System.Windows.Forms.ToolStripButton();
            this.btnEditMinimap = new System.Windows.Forms.ToolStripButton();
            this.btnEditTexAnim = new System.Windows.Forms.ToolStripButton();
            this.btnCLPS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnEdit3DModel = new System.Windows.Forms.ToolStripButton();
            this.btnEditObjects = new System.Windows.Forms.ToolStripButton();
            this.btnEditWarps = new System.Windows.Forms.ToolStripButton();
            this.btnEditPaths = new System.Windows.Forms.ToolStripButton();
            this.btnEditViews = new System.Windows.Forms.ToolStripButton();
            this.btnEditMisc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnStar1 = new System.Windows.Forms.ToolStripButton();
            this.btnStar2 = new System.Windows.Forms.ToolStripButton();
            this.btnStar3 = new System.Windows.Forms.ToolStripButton();
            this.btnStar4 = new System.Windows.Forms.ToolStripButton();
            this.btnStar5 = new System.Windows.Forms.ToolStripButton();
            this.btnStar6 = new System.Windows.Forms.ToolStripButton();
            this.btnStar7 = new System.Windows.Forms.ToolStripButton();
            this.btnStarAll = new System.Windows.Forms.ToolStripButton();
            this.ssStatusBar = new System.Windows.Forms.StatusStrip();
            this.slStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPasteCoordinates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).BeginInit();
            this.spcMainContainer.Panel1.SuspendLayout();
            this.spcMainContainer.Panel2.SuspendLayout();
            this.spcMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLeftPanel)).BeginInit();
            this.spcLeftPanel.Panel1.SuspendLayout();
            this.spcLeftPanel.Panel2.SuspendLayout();
            this.spcLeftPanel.SuspendLayout();
            this.tsEditActions.SuspendLayout();
            this.tsViewActions.SuspendLayout();
            this.tsToolBar.SuspendLayout();
            this.ssStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMainContainer
            // 
            this.spcMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcMainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcMainContainer.Location = new System.Drawing.Point(0, 25);
            this.spcMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.spcMainContainer.Name = "spcMainContainer";
            // 
            // spcMainContainer.Panel1
            // 
            this.spcMainContainer.Panel1.Controls.Add(this.spcLeftPanel);
            this.spcMainContainer.Panel1.Controls.Add(this.tsEditActions);
            // 
            // spcMainContainer.Panel2
            // 
            this.spcMainContainer.Panel2.Controls.Add(this.glLevelView);
            this.spcMainContainer.Panel2.Controls.Add(this.tsViewActions);
            this.spcMainContainer.Size = new System.Drawing.Size(957, 486);
            this.spcMainContainer.SplitterDistance = 264;
            this.spcMainContainer.TabIndex = 0;
            // 
            // spcLeftPanel
            // 
            this.spcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcLeftPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcLeftPanel.Location = new System.Drawing.Point(0, 132);
            this.spcLeftPanel.Name = "spcLeftPanel";
            this.spcLeftPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcLeftPanel.Panel1
            // 
            this.spcLeftPanel.Panel1.Controls.Add(this.tvObjectList);
            // 
            // spcLeftPanel.Panel2
            // 
            this.spcLeftPanel.Panel2.Controls.Add(this.btnPasteCoordinates);
            this.spcLeftPanel.Panel2.Controls.Add(this.btnCopyCoordinates);
            this.spcLeftPanel.Panel2.Controls.Add(this.pgObjectProperties);
            this.spcLeftPanel.Size = new System.Drawing.Size(264, 354);
            this.spcLeftPanel.SplitterDistance = 76;
            this.spcLeftPanel.TabIndex = 1;
            // 
            // tvObjectList
            // 
            this.tvObjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvObjectList.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvObjectList.HideSelection = false;
            this.tvObjectList.Location = new System.Drawing.Point(0, 0);
            this.tvObjectList.Name = "tvObjectList";
            this.tvObjectList.Size = new System.Drawing.Size(264, 76);
            this.tvObjectList.TabIndex = 0;
            this.tvObjectList.TabStop = false;
            this.tvObjectList.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.tvObjectList_DrawNode);
            this.tvObjectList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvObjectList_AfterSelect);
            // 
            // btnCopyCoordinates
            // 
            this.btnCopyCoordinates.Location = new System.Drawing.Point(0, 251);
            this.btnCopyCoordinates.Name = "btnCopyCoordinates";
            this.btnCopyCoordinates.Size = new System.Drawing.Size(128, 23);
            this.btnCopyCoordinates.TabIndex = 1;
            this.btnCopyCoordinates.Text = "CopyCoordinates";
            this.btnCopyCoordinates.UseVisualStyleBackColor = true;
            this.btnCopyCoordinates.Visible = false;
            this.btnCopyCoordinates.Click += new System.EventHandler(this.btnCopyCoordinates_Click);
            // 
            // pgObjectProperties
            // 
            this.pgObjectProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgObjectProperties.LineColor = System.Drawing.SystemColors.ControlDark;
            this.pgObjectProperties.Location = new System.Drawing.Point(0, 0);
            this.pgObjectProperties.Name = "pgObjectProperties";
            this.pgObjectProperties.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.pgObjectProperties.Size = new System.Drawing.Size(264, 274);
            this.pgObjectProperties.TabIndex = 0;
            this.pgObjectProperties.ToolbarVisible = false;
            this.pgObjectProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgObjectProperties_PropertyValueChanged);
            // 
            // tsEditActions
            // 
            this.tsEditActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportModel,
            this.btnExportLevelModel,
            this.btnAddObject,
            this.btnAddWarp,
            this.btnAddView,
            this.btnRemoveSel,
            this.btnRemoveAll,
            this.btnReplaceObjModel,
            this.btnExportObjectModel,
            this.btnAddPathNodes,
            this.btnAddPath,
            this.btnAddMisc,
            this.btnImportOtherModel,
            this.btnExportOtherModel,
            this.btnOffsetAllCoords});
            this.tsEditActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsEditActions.Location = new System.Drawing.Point(0, 0);
            this.tsEditActions.Name = "tsEditActions";
            this.tsEditActions.Size = new System.Drawing.Size(264, 132);
            this.tsEditActions.TabIndex = 0;
            this.tsEditActions.Text = "toolStrip1";
            // 
            // btnImportModel
            // 
            this.btnImportModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImportModel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportModel.Image")));
            this.btnImportModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportModel.Name = "btnImportModel";
            this.btnImportModel.Size = new System.Drawing.Size(111, 19);
            this.btnImportModel.Text = "Import level model";
            this.btnImportModel.ToolTipText = "Replace the 3D model with one from a .obj file";
            this.btnImportModel.Click += new System.EventHandler(this.btnImportModel_Click);
            // 
            // btnExportLevelModel
            // 
            this.btnExportLevelModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExportLevelModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportLevelModel.Name = "btnExportLevelModel";
            this.btnExportLevelModel.Size = new System.Drawing.Size(108, 19);
            this.btnExportLevelModel.Text = "Export level model";
            this.btnExportLevelModel.Click += new System.EventHandler(this.btnExportLevelModel_Click);
            // 
            // btnAddObject
            // 
            this.btnAddObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddObject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddObject.Image")));
            this.btnAddObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(69, 19);
            this.btnAddObject.Tag = "1,1";
            this.btnAddObject.Text = "Add object";
            this.btnAddObject.ToolTipText = "Add an enemy, item or whatever";
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
            // 
            // btnAddWarp
            // 
            this.btnAddWarp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddWarp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddEntrance,
            this.btnAddExit,
            this.btnAddAreaWarp,
            this.btnAddTpSrc,
            this.btnAddTpDst});
            this.btnAddWarp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddWarp.Image")));
            this.btnAddWarp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddWarp.Name = "btnAddWarp";
            this.btnAddWarp.Size = new System.Drawing.Size(71, 19);
            this.btnAddWarp.Text = "Add warp";
            this.btnAddWarp.ToolTipText = "Add an entrance, exit, door, teleport or whatever";
            // 
            // btnAddEntrance
            // 
            this.btnAddEntrance.Name = "btnAddEntrance";
            this.btnAddEntrance.Size = new System.Drawing.Size(179, 22);
            this.btnAddEntrance.Tag = "1";
            this.btnAddEntrance.Text = "Entrance";
            this.btnAddEntrance.Click += new System.EventHandler(this.btnAddWhatever_Click);
            // 
            // btnAddExit
            // 
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(179, 22);
            this.btnAddExit.Tag = "10";
            this.btnAddExit.Text = "Exit";
            this.btnAddExit.Click += new System.EventHandler(this.btnAddWhatever_Click);
            // 
            // btnAddAreaWarp
            // 
            this.btnAddAreaWarp.Name = "btnAddAreaWarp";
            this.btnAddAreaWarp.Size = new System.Drawing.Size(179, 22);
            this.btnAddAreaWarp.Tag = "9";
            this.btnAddAreaWarp.Text = "Door";
            this.btnAddAreaWarp.Click += new System.EventHandler(this.btnAddWhatever_Click);
            // 
            // btnAddTpSrc
            // 
            this.btnAddTpSrc.Name = "btnAddTpSrc";
            this.btnAddTpSrc.Size = new System.Drawing.Size(179, 22);
            this.btnAddTpSrc.Tag = "6";
            this.btnAddTpSrc.Text = "Teleport source";
            this.btnAddTpSrc.Click += new System.EventHandler(this.btnAddWhatever_Click);
            // 
            // btnAddTpDst
            // 
            this.btnAddTpDst.Name = "btnAddTpDst";
            this.btnAddTpDst.Size = new System.Drawing.Size(179, 22);
            this.btnAddTpDst.Tag = "7";
            this.btnAddTpDst.Text = "Teleport destination";
            this.btnAddTpDst.Click += new System.EventHandler(this.btnAddWhatever_Click);
            // 
            // btnAddView
            // 
            this.btnAddView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddView.Image = ((System.Drawing.Image)(resources.GetObject("btnAddView.Image")));
            this.btnAddView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddView.Name = "btnAddView";
            this.btnAddView.Size = new System.Drawing.Size(60, 19);
            this.btnAddView.Tag = "4";
            this.btnAddView.Text = "Add view";
            this.btnAddView.ToolTipText = "Add a view (camera anchor)";
            this.btnAddView.Click += new System.EventHandler(this.btnAddWhatever_Click);
            // 
            // btnRemoveSel
            // 
            this.btnRemoveSel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveSel.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveSel.Image")));
            this.btnRemoveSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveSel.Name = "btnRemoveSel";
            this.btnRemoveSel.Size = new System.Drawing.Size(90, 19);
            this.btnRemoveSel.Text = "Remove object";
            this.btnRemoveSel.ToolTipText = "Remove an object.";
            this.btnRemoveSel.Click += new System.EventHandler(this.btnRemoveSel_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(69, 19);
            this.btnRemoveAll.Text = "Remove all";
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnReplaceObjModel
            // 
            this.btnReplaceObjModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReplaceObjModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReplaceObjModel.Name = "btnReplaceObjModel";
            this.btnReplaceObjModel.Size = new System.Drawing.Size(89, 19);
            this.btnReplaceObjModel.Text = "Replace model";
            this.btnReplaceObjModel.Click += new System.EventHandler(this.btnReplaceObjModel_Click);
            // 
            // btnExportObjectModel
            // 
            this.btnExportObjectModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExportObjectModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportObjectModel.Name = "btnExportObjectModel";
            this.btnExportObjectModel.Size = new System.Drawing.Size(81, 19);
            this.btnExportObjectModel.Text = "Export model";
            this.btnExportObjectModel.Click += new System.EventHandler(this.btnExportObjectModel_Click);
            // 
            // btnAddPathNodes
            // 
            this.btnAddPathNodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddPathNodes.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPathNodes.Image")));
            this.btnAddPathNodes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPathNodes.Name = "btnAddPathNodes";
            this.btnAddPathNodes.Size = new System.Drawing.Size(101, 19);
            this.btnAddPathNodes.Text = "Add Path Node";
            this.btnAddPathNodes.ToolTipText = "Add Node To Path";
            this.btnAddPathNodes.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnAddPathNodes_DropDownItemClicked);
            // 
            // btnAddPath
            // 
            this.btnAddPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(60, 19);
            this.btnAddPath.Text = "Add Path";
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // btnAddMisc
            // 
            this.btnAddMisc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddMisc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.btnAddMisc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMisc.Name = "btnAddMisc";
            this.btnAddMisc.Size = new System.Drawing.Size(111, 19);
            this.btnAddMisc.Text = "Add Misc. Object";
            this.btnAddMisc.ToolTipText = "Add Miscellaneous Object";
            this.btnAddMisc.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnAddMisc_DropDownItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem1.Tag = "8";
            this.toolStripMenuItem1.Text = "Fog";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem2.Tag = "12";
            this.toolStripMenuItem2.Text = "Minimap Scale";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem3.Tag = "11";
            this.toolStripMenuItem3.Text = "Minimap Tile ID";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem4.Tag = "14";
            this.toolStripMenuItem4.Text = "Unkown Type 14";
            // 
            // btnImportOtherModel
            // 
            this.btnImportOtherModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImportOtherModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportOtherModel.Name = "btnImportOtherModel";
            this.btnImportOtherModel.Size = new System.Drawing.Size(115, 19);
            this.btnImportOtherModel.Text = "Import other model";
            this.btnImportOtherModel.Click += new System.EventHandler(this.btnImportOtherModel_Click);
            // 
            // btnExportOtherModel
            // 
            this.btnExportOtherModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExportOtherModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportOtherModel.Name = "btnExportOtherModel";
            this.btnExportOtherModel.Size = new System.Drawing.Size(112, 19);
            this.btnExportOtherModel.Text = "Export other model";
            this.btnExportOtherModel.Click += new System.EventHandler(this.btnExportOtherModel_Click);
            // 
            // btnOffsetAllCoords
            // 
            this.btnOffsetAllCoords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOffsetAllCoords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOffsetAllCoords.Name = "btnOffsetAllCoords";
            this.btnOffsetAllCoords.Size = new System.Drawing.Size(106, 19);
            this.btnOffsetAllCoords.Text = "Offset All Co-ords";
            this.btnOffsetAllCoords.Click += new System.EventHandler(this.btnOffsetAllCoords_Click);
            // 
            // glLevelView
            // 
            this.glLevelView.BackColor = System.Drawing.Color.Black;
            this.glLevelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glLevelView.Location = new System.Drawing.Point(0, 25);
            this.glLevelView.Name = "glLevelView";
            this.glLevelView.Size = new System.Drawing.Size(689, 461);
            this.glLevelView.TabIndex = 1;
            this.glLevelView.VSync = false;
            this.glLevelView.Load += new System.EventHandler(this.glLevelView_Load);
            this.glLevelView.Paint += new System.Windows.Forms.PaintEventHandler(this.glLevelView_Paint);
            this.glLevelView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glLevelView_KeyDown);
            this.glLevelView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.glLevelView_KeyUp);
            this.glLevelView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glLevelView_MouseDown);
            this.glLevelView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glLevelView_MouseMove);
            this.glLevelView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glLevelView_MouseUp);
            this.glLevelView.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glLevelView_MouseWheel);
            this.glLevelView.Resize += new System.EventHandler(this.glLevelView_Resize);
            // 
            // tsViewActions
            // 
            this.tsViewActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLOL,
            this.btnImportXML,
            this.btnExportXML,
            this.btnScreenshot,
            this.toolStripSeparator4,
            this.btnOrthView,
            this.menuGridSettings,
            this.menuRestrictionPlane,
            this.btnMakeOverlay});
            this.tsViewActions.Location = new System.Drawing.Point(0, 0);
            this.tsViewActions.Name = "tsViewActions";
            this.tsViewActions.Size = new System.Drawing.Size(689, 25);
            this.tsViewActions.TabIndex = 0;
            this.tsViewActions.Text = "toolStrip2";
            // 
            // btnLOL
            // 
            this.btnLOL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLOL.Image = ((System.Drawing.Image)(resources.GetObject("btnLOL.Image")));
            this.btnLOL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLOL.Name = "btnLOL";
            this.btnLOL.Size = new System.Drawing.Size(24, 22);
            this.btnLOL.Text = "lol";
            this.btnLOL.ToolTipText = "general purpose button";
            this.btnLOL.Visible = false;
            this.btnLOL.Click += new System.EventHandler(this.btnLOL_Click);
            // 
            // btnImportXML
            // 
            this.btnImportXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImportXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportXML.Name = "btnImportXML";
            this.btnImportXML.Size = new System.Drawing.Size(74, 22);
            this.btnImportXML.Text = "Import XML";
            this.btnImportXML.Click += new System.EventHandler(this.btnImportXML_Click);
            // 
            // btnExportXML
            // 
            this.btnExportXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExportXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportXML.Name = "btnExportXML";
            this.btnExportXML.Size = new System.Drawing.Size(71, 22);
            this.btnExportXML.Text = "Export XML";
            this.btnExportXML.Click += new System.EventHandler(this.btnExportXML_Click);
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnScreenshot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnScreenshot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(69, 22);
            this.btnScreenshot.Text = "Screenshot";
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOrthView
            // 
            this.btnOrthView.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOrthView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOrthView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrthView.Name = "btnOrthView";
            this.btnOrthView.Size = new System.Drawing.Size(100, 22);
            this.btnOrthView.Text = "Orthogonal View";
            this.btnOrthView.Click += new System.EventHandler(this.btnOrthView_Click);
            // 
            // menuGridSettings
            // 
            this.menuGridSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuGridSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtGridSizeX,
            this.txtGridSizeY,
            this.txtGridSizeZ,
            this.toolStripSeparator5,
            this.txtGridOffsetX,
            this.txtGridOffsetY,
            this.txtGridOffsetZ});
            this.menuGridSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuGridSettings.Name = "menuGridSettings";
            this.menuGridSettings.Size = new System.Drawing.Size(42, 22);
            this.menuGridSettings.Text = "Grid";
            this.menuGridSettings.DropDownClosed += new System.EventHandler(this.menuGridSettings_DropDownClosed);
            // 
            // txtGridSizeX
            // 
            this.txtGridSizeX.Name = "txtGridSizeX";
            this.txtGridSizeX.Size = new System.Drawing.Size(100, 23);
            this.txtGridSizeX.Text = "0.0";
            this.txtGridSizeX.ToolTipText = "Size X";
            // 
            // txtGridSizeY
            // 
            this.txtGridSizeY.Name = "txtGridSizeY";
            this.txtGridSizeY.Size = new System.Drawing.Size(100, 23);
            this.txtGridSizeY.Text = "0.0";
            this.txtGridSizeY.ToolTipText = "Size Y";
            // 
            // txtGridSizeZ
            // 
            this.txtGridSizeZ.Name = "txtGridSizeZ";
            this.txtGridSizeZ.Size = new System.Drawing.Size(100, 23);
            this.txtGridSizeZ.Text = "0.0";
            this.txtGridSizeZ.ToolTipText = "Size Z";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // txtGridOffsetX
            // 
            this.txtGridOffsetX.Name = "txtGridOffsetX";
            this.txtGridOffsetX.Size = new System.Drawing.Size(100, 23);
            this.txtGridOffsetX.Text = "0.0";
            this.txtGridOffsetX.ToolTipText = "Offset X";
            // 
            // txtGridOffsetY
            // 
            this.txtGridOffsetY.Name = "txtGridOffsetY";
            this.txtGridOffsetY.Size = new System.Drawing.Size(100, 23);
            this.txtGridOffsetY.Text = "0.0";
            this.txtGridOffsetY.ToolTipText = "Offset Y";
            // 
            // txtGridOffsetZ
            // 
            this.txtGridOffsetZ.Name = "txtGridOffsetZ";
            this.txtGridOffsetZ.Size = new System.Drawing.Size(100, 23);
            this.txtGridOffsetZ.Text = "0.0";
            this.txtGridOffsetZ.ToolTipText = "Offset Z";
            // 
            // menuRestrictionPlane
            // 
            this.menuRestrictionPlane.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuRestrictionPlane.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtRstPlaneX,
            this.txtRstPlaneY,
            this.txtRstPlaneZ,
            this.toolStripSeparator6,
            this.txtRstPlaneOffX,
            this.txtRstPlaneOffY,
            this.txtRstPlaneOffZ});
            this.menuRestrictionPlane.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuRestrictionPlane.Name = "menuRestrictionPlane";
            this.menuRestrictionPlane.Size = new System.Drawing.Size(108, 22);
            this.menuRestrictionPlane.Text = "Restriction Plane";
            this.menuRestrictionPlane.DropDownClosed += new System.EventHandler(this.menuRestrictionPlane_DropDownClosed);
            // 
            // txtRstPlaneX
            // 
            this.txtRstPlaneX.Name = "txtRstPlaneX";
            this.txtRstPlaneX.Size = new System.Drawing.Size(100, 23);
            this.txtRstPlaneX.Text = "0.0";
            this.txtRstPlaneX.ToolTipText = "Normal X";
            // 
            // txtRstPlaneY
            // 
            this.txtRstPlaneY.Name = "txtRstPlaneY";
            this.txtRstPlaneY.Size = new System.Drawing.Size(100, 23);
            this.txtRstPlaneY.Text = "0.0";
            this.txtRstPlaneY.ToolTipText = "Normal Y";
            // 
            // txtRstPlaneZ
            // 
            this.txtRstPlaneZ.Name = "txtRstPlaneZ";
            this.txtRstPlaneZ.Size = new System.Drawing.Size(100, 23);
            this.txtRstPlaneZ.Text = "0.0";
            this.txtRstPlaneZ.ToolTipText = "Normal Z";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(157, 6);
            // 
            // txtRstPlaneOffX
            // 
            this.txtRstPlaneOffX.Name = "txtRstPlaneOffX";
            this.txtRstPlaneOffX.Size = new System.Drawing.Size(100, 23);
            this.txtRstPlaneOffX.Text = "0.0";
            // 
            // txtRstPlaneOffY
            // 
            this.txtRstPlaneOffY.Name = "txtRstPlaneOffY";
            this.txtRstPlaneOffY.Size = new System.Drawing.Size(100, 23);
            this.txtRstPlaneOffY.Text = "0.0";
            // 
            // txtRstPlaneOffZ
            // 
            this.txtRstPlaneOffZ.Name = "txtRstPlaneOffZ";
            this.txtRstPlaneOffZ.Size = new System.Drawing.Size(100, 23);
            this.txtRstPlaneOffZ.Text = "0.0";
            this.txtRstPlaneOffZ.ToolTipText = "Distance from Origin";
            // 
            // btnMakeOverlay
            // 
            this.btnMakeOverlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMakeOverlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMakeOverlay.Name = "btnMakeOverlay";
            this.btnMakeOverlay.Size = new System.Drawing.Size(113, 22);
            this.btnMakeOverlay.Text = "Make Level Overlay";
            this.btnMakeOverlay.ToolTipText = "Ready to show off your level coding skills?";
            this.btnMakeOverlay.Click += new System.EventHandler(this.btnMakeOverlay_Click);
            // 
            // tsToolBar
            // 
            this.tsToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnLevelSettings,
            this.btnEditMinimap,
            this.btnEditTexAnim,
            this.btnCLPS,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.btnEdit3DModel,
            this.btnEditObjects,
            this.btnEditWarps,
            this.btnEditPaths,
            this.btnEditViews,
            this.btnEditMisc,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.btnStar1,
            this.btnStar2,
            this.btnStar3,
            this.btnStar4,
            this.btnStar5,
            this.btnStar6,
            this.btnStar7,
            this.btnStarAll});
            this.tsToolBar.Location = new System.Drawing.Point(0, 0);
            this.tsToolBar.Name = "tsToolBar";
            this.tsToolBar.Size = new System.Drawing.Size(957, 25);
            this.tsToolBar.TabIndex = 1;
            this.tsToolBar.TabStop = true;
            this.tsToolBar.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 22);
            this.btnSave.Text = "Save";
            this.btnSave.ToolTipText = "Click me regularly if you don\'t\r\nwant to lose your changes.";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLevelSettings
            // 
            this.btnLevelSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLevelSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnLevelSettings.Image")));
            this.btnLevelSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLevelSettings.Name = "btnLevelSettings";
            this.btnLevelSettings.Size = new System.Drawing.Size(82, 22);
            this.btnLevelSettings.Text = "Level settings";
            this.btnLevelSettings.ToolTipText = "Change the sky, the object banks and all that.";
            this.btnLevelSettings.Click += new System.EventHandler(this.btnLevelSettings_Click);
            // 
            // btnEditMinimap
            // 
            this.btnEditMinimap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditMinimap.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMinimap.Image")));
            this.btnEditMinimap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditMinimap.Name = "btnEditMinimap";
            this.btnEditMinimap.Size = new System.Drawing.Size(59, 22);
            this.btnEditMinimap.Text = "Minimap";
            this.btnEditMinimap.ToolTipText = "Edit those graphics on the bottom screen";
            this.btnEditMinimap.Click += new System.EventHandler(this.btnEditMinimap_Click);
            // 
            // btnEditTexAnim
            // 
            this.btnEditTexAnim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditTexAnim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditTexAnim.Name = "btnEditTexAnim";
            this.btnEditTexAnim.Size = new System.Drawing.Size(106, 22);
            this.btnEditTexAnim.Text = "Texture animation";
            this.btnEditTexAnim.Click += new System.EventHandler(this.btnEditTexAnim_Click);
            // 
            // btnCLPS
            // 
            this.btnCLPS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCLPS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCLPS.Name = "btnCLPS";
            this.btnCLPS.Size = new System.Drawing.Size(38, 22);
            this.btnCLPS.Text = "CLPS";
            this.btnCLPS.Click += new System.EventHandler(this.btnCLPS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel4.Text = "Edit:";
            // 
            // btnEdit3DModel
            // 
            this.btnEdit3DModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit3DModel.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit3DModel.Image")));
            this.btnEdit3DModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit3DModel.Name = "btnEdit3DModel";
            this.btnEdit3DModel.Size = new System.Drawing.Size(62, 22);
            this.btnEdit3DModel.Tag = "0";
            this.btnEdit3DModel.Text = "3D model";
            this.btnEdit3DModel.ToolTipText = "Let\'s add polygons!";
            this.btnEdit3DModel.Click += new System.EventHandler(this.btnEditXXX_Click);
            // 
            // btnEditObjects
            // 
            this.btnEditObjects.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditObjects.Image = ((System.Drawing.Image)(resources.GetObject("btnEditObjects.Image")));
            this.btnEditObjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditObjects.Name = "btnEditObjects";
            this.btnEditObjects.Size = new System.Drawing.Size(51, 22);
            this.btnEditObjects.Tag = "1";
            this.btnEditObjects.Text = "Objects";
            this.btnEditObjects.ToolTipText = "Add coins, trees, Goombas and whatnot";
            this.btnEditObjects.Click += new System.EventHandler(this.btnEditXXX_Click);
            // 
            // btnEditWarps
            // 
            this.btnEditWarps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditWarps.Image = ((System.Drawing.Image)(resources.GetObject("btnEditWarps.Image")));
            this.btnEditWarps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditWarps.Name = "btnEditWarps";
            this.btnEditWarps.Size = new System.Drawing.Size(44, 22);
            this.btnEditWarps.Tag = "2";
            this.btnEditWarps.Text = "Warps";
            this.btnEditWarps.ToolTipText = "Modify the entrances and exits";
            this.btnEditWarps.Click += new System.EventHandler(this.btnEditXXX_Click);
            // 
            // btnEditPaths
            // 
            this.btnEditPaths.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditPaths.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPaths.Image")));
            this.btnEditPaths.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditPaths.Name = "btnEditPaths";
            this.btnEditPaths.Size = new System.Drawing.Size(40, 22);
            this.btnEditPaths.Tag = "3";
            this.btnEditPaths.Text = "Paths";
            this.btnEditPaths.ToolTipText = "Make some objects follow funny paths";
            this.btnEditPaths.Click += new System.EventHandler(this.btnEditXXX_Click);
            // 
            // btnEditViews
            // 
            this.btnEditViews.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditViews.Image = ((System.Drawing.Image)(resources.GetObject("btnEditViews.Image")));
            this.btnEditViews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditViews.Name = "btnEditViews";
            this.btnEditViews.Size = new System.Drawing.Size(41, 22);
            this.btnEditViews.Tag = "4";
            this.btnEditViews.Text = "Views";
            this.btnEditViews.ToolTipText = "Change view angles";
            this.btnEditViews.Click += new System.EventHandler(this.btnEditXXX_Click);
            // 
            // btnEditMisc
            // 
            this.btnEditMisc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditMisc.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMisc.Image")));
            this.btnEditMisc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditMisc.Name = "btnEditMisc";
            this.btnEditMisc.Size = new System.Drawing.Size(36, 22);
            this.btnEditMisc.Tag = "5";
            this.btnEditMisc.Text = "Misc";
            this.btnEditMisc.ToolTipText = "Minimap settings and all...";
            this.btnEditMisc.Click += new System.EventHandler(this.btnEditXXX_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "For star:";
            // 
            // btnStar1
            // 
            this.btnStar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStar1.Image = ((System.Drawing.Image)(resources.GetObject("btnStar1.Image")));
            this.btnStar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStar1.Name = "btnStar1";
            this.btnStar1.Size = new System.Drawing.Size(23, 22);
            this.btnStar1.Tag = "1";
            this.btnStar1.Text = "1";
            this.btnStar1.Click += new System.EventHandler(this.btnStarX_Click);
            // 
            // btnStar2
            // 
            this.btnStar2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStar2.Image = ((System.Drawing.Image)(resources.GetObject("btnStar2.Image")));
            this.btnStar2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStar2.Name = "btnStar2";
            this.btnStar2.Size = new System.Drawing.Size(23, 22);
            this.btnStar2.Tag = "2";
            this.btnStar2.Text = "2";
            this.btnStar2.Click += new System.EventHandler(this.btnStarX_Click);
            // 
            // btnStar3
            // 
            this.btnStar3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStar3.Image = ((System.Drawing.Image)(resources.GetObject("btnStar3.Image")));
            this.btnStar3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStar3.Name = "btnStar3";
            this.btnStar3.Size = new System.Drawing.Size(23, 22);
            this.btnStar3.Tag = "3";
            this.btnStar3.Text = "3";
            this.btnStar3.Click += new System.EventHandler(this.btnStarX_Click);
            // 
            // btnStar4
            // 
            this.btnStar4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStar4.Image = ((System.Drawing.Image)(resources.GetObject("btnStar4.Image")));
            this.btnStar4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStar4.Name = "btnStar4";
            this.btnStar4.Size = new System.Drawing.Size(23, 22);
            this.btnStar4.Tag = "4";
            this.btnStar4.Text = "4";
            this.btnStar4.Click += new System.EventHandler(this.btnStarX_Click);
            // 
            // btnStar5
            // 
            this.btnStar5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStar5.Image = ((System.Drawing.Image)(resources.GetObject("btnStar5.Image")));
            this.btnStar5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStar5.Name = "btnStar5";
            this.btnStar5.Size = new System.Drawing.Size(23, 22);
            this.btnStar5.Tag = "5";
            this.btnStar5.Text = "5";
            this.btnStar5.Click += new System.EventHandler(this.btnStarX_Click);
            // 
            // btnStar6
            // 
            this.btnStar6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStar6.Image = ((System.Drawing.Image)(resources.GetObject("btnStar6.Image")));
            this.btnStar6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStar6.Name = "btnStar6";
            this.btnStar6.Size = new System.Drawing.Size(23, 22);
            this.btnStar6.Tag = "6";
            this.btnStar6.Text = "6";
            this.btnStar6.Click += new System.EventHandler(this.btnStarX_Click);
            // 
            // btnStar7
            // 
            this.btnStar7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStar7.Image = ((System.Drawing.Image)(resources.GetObject("btnStar7.Image")));
            this.btnStar7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStar7.Name = "btnStar7";
            this.btnStar7.Size = new System.Drawing.Size(23, 22);
            this.btnStar7.Tag = "7";
            this.btnStar7.Text = "7";
            this.btnStar7.Click += new System.EventHandler(this.btnStarX_Click);
            // 
            // btnStarAll
            // 
            this.btnStarAll.CheckOnClick = true;
            this.btnStarAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStarAll.DoubleClickEnabled = true;
            this.btnStarAll.Image = ((System.Drawing.Image)(resources.GetObject("btnStarAll.Image")));
            this.btnStarAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStarAll.Name = "btnStarAll";
            this.btnStarAll.Size = new System.Drawing.Size(52, 22);
            this.btnStarAll.Text = "All stars";
            this.btnStarAll.ToolTipText = "Common objects";
            this.btnStarAll.Click += new System.EventHandler(this.btnStarAll_Click);
            this.btnStarAll.DoubleClick += new System.EventHandler(this.btnStarAll_DoubleClick);
            // 
            // ssStatusBar
            // 
            this.ssStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slStatusLabel});
            this.ssStatusBar.Location = new System.Drawing.Point(0, 511);
            this.ssStatusBar.Name = "ssStatusBar";
            this.ssStatusBar.Size = new System.Drawing.Size(957, 22);
            this.ssStatusBar.TabIndex = 2;
            this.ssStatusBar.Text = "statusStrip1";
            // 
            // slStatusLabel
            // 
            this.slStatusLabel.Name = "slStatusLabel";
            this.slStatusLabel.Size = new System.Drawing.Size(942, 17);
            this.slStatusLabel.Spring = true;
            this.slStatusLabel.Text = "status!";
            this.slStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slStatusLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.slStatusLabel_Paint);
            this.slStatusLabel.TextChanged += new System.EventHandler(this.slStatusLabel_TextChanged);
            // 
            // btnPasteCoordinates
            // 
            this.btnPasteCoordinates.Enabled = false;
            this.btnPasteCoordinates.Location = new System.Drawing.Point(134, 251);
            this.btnPasteCoordinates.Name = "btnPasteCoordinates";
            this.btnPasteCoordinates.Size = new System.Drawing.Size(130, 23);
            this.btnPasteCoordinates.TabIndex = 2;
            this.btnPasteCoordinates.Text = "PasteCoordinates";
            this.btnPasteCoordinates.UseVisualStyleBackColor = true;
            this.btnPasteCoordinates.Visible = false;
            this.btnPasteCoordinates.Click += new System.EventHandler(this.btnPasteCoordinates_Click);
            // 
            // LevelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 533);
            this.Controls.Add(this.ssStatusBar);
            this.Controls.Add(this.tsToolBar);
            this.Controls.Add(this.spcMainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LevelEditorForm";
            this.Text = "LevelEditorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelEditorForm_FormClosing);
            this.spcMainContainer.Panel1.ResumeLayout(false);
            this.spcMainContainer.Panel1.PerformLayout();
            this.spcMainContainer.Panel2.ResumeLayout(false);
            this.spcMainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainContainer)).EndInit();
            this.spcMainContainer.ResumeLayout(false);
            this.spcLeftPanel.Panel1.ResumeLayout(false);
            this.spcLeftPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcLeftPanel)).EndInit();
            this.spcLeftPanel.ResumeLayout(false);
            this.tsEditActions.ResumeLayout(false);
            this.tsEditActions.PerformLayout();
            this.tsViewActions.ResumeLayout(false);
            this.tsViewActions.PerformLayout();
            this.tsToolBar.ResumeLayout(false);
            this.tsToolBar.PerformLayout();
            this.ssStatusBar.ResumeLayout(false);
            this.ssStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMainContainer;
        private System.Windows.Forms.ToolStrip tsToolBar;
        private System.Windows.Forms.StatusStrip ssStatusBar;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLevelSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip tsViewActions;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnEditObjects;
        private System.Windows.Forms.ToolStripButton btnEdit3DModel;
        private System.Windows.Forms.ToolStripButton btnEditWarps;
        private System.Windows.Forms.ToolStripButton btnEditPaths;
        private System.Windows.Forms.ToolStripButton btnEditViews;
        private System.Windows.Forms.ToolStripButton btnEditMisc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnStar1;
        private System.Windows.Forms.ToolStripButton btnStar2;
        private System.Windows.Forms.ToolStripButton btnStar3;
        private System.Windows.Forms.ToolStripButton btnStar4;
        private System.Windows.Forms.ToolStripButton btnStar5;
        private System.Windows.Forms.ToolStripButton btnStar6;
        private System.Windows.Forms.ToolStripButton btnStar7;
        private System.Windows.Forms.ToolStripButton btnStarAll;
        private System.Windows.Forms.SplitContainer spcLeftPanel;
        private System.Windows.Forms.TreeView tvObjectList;
        private System.Windows.Forms.ToolStrip tsEditActions;
        private System.Windows.Forms.PropertyGrid pgObjectProperties;
        private System.Windows.Forms.ToolStripStatusLabel slStatusLabel;
        private System.Windows.Forms.ToolStripButton btnImportModel;
        private System.Windows.Forms.ToolStripButton btnRemoveSel;
        private System.Windows.Forms.ToolStripButton btnAddObject;
        private System.Windows.Forms.ToolStripDropDownButton btnAddWarp;
        private System.Windows.Forms.ToolStripMenuItem btnAddEntrance;
        private System.Windows.Forms.ToolStripMenuItem btnAddExit;
        private System.Windows.Forms.ToolStripMenuItem btnAddAreaWarp;
        private System.Windows.Forms.ToolStripMenuItem btnAddTpSrc;
        private System.Windows.Forms.ToolStripMenuItem btnAddTpDst;
        private System.Windows.Forms.ToolStripButton btnAddView;
        private System.Windows.Forms.ToolStripButton btnLOL;
        private OpenTK.GLControl glLevelView;
        private System.Windows.Forms.ToolStripButton btnEditMinimap;
        private System.Windows.Forms.ToolStripButton btnReplaceObjModel;
        private System.Windows.Forms.ToolStripButton btnExportObjectModel;
        private System.Windows.Forms.ToolStripButton btnEditTexAnim;
        private System.Windows.Forms.ToolStripButton btnCLPS;
        private System.Windows.Forms.ToolStripDropDownButton btnAddPathNodes;
        private System.Windows.Forms.ToolStripButton btnAddPath;
        private System.Windows.Forms.ToolStripDropDownButton btnAddMisc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripButton btnImportOtherModel;
        private System.Windows.Forms.ToolStripButton btnExportOtherModel;
        private System.Windows.Forms.ToolStripButton btnOffsetAllCoords;
        private System.Windows.Forms.ToolStripButton btnExportLevelModel;
        private System.Windows.Forms.ToolStripButton btnImportXML;
        private System.Windows.Forms.ToolStripButton btnExportXML;
        private System.Windows.Forms.ToolStripButton btnOrthView;
        private System.Windows.Forms.ToolStripButton btnScreenshot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton menuGridSettings;
        private System.Windows.Forms.ToolStripTextBox txtGridSizeX;
        private System.Windows.Forms.ToolStripTextBox txtGridSizeY;
        private System.Windows.Forms.ToolStripTextBox txtGridSizeZ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox txtGridOffsetX;
        private System.Windows.Forms.ToolStripTextBox txtGridOffsetY;
        private System.Windows.Forms.ToolStripTextBox txtGridOffsetZ;
        private System.Windows.Forms.ToolStripDropDownButton menuRestrictionPlane;
        private System.Windows.Forms.ToolStripTextBox txtRstPlaneX;
        private System.Windows.Forms.ToolStripTextBox txtRstPlaneY;
        private System.Windows.Forms.ToolStripTextBox txtRstPlaneZ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox txtRstPlaneOffZ;
        private System.Windows.Forms.ToolStripTextBox txtRstPlaneOffX;
        private System.Windows.Forms.ToolStripTextBox txtRstPlaneOffY;
        private System.Windows.Forms.ToolStripButton btnMakeOverlay;
        private System.Windows.Forms.ToolStripButton btnRemoveAll;
        private System.Windows.Forms.Button btnCopyCoordinates;
        private System.Windows.Forms.Button btnPasteCoordinates;
    }
}