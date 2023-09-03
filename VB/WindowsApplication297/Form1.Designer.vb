Namespace WindowsApplication297

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Location = New System.Drawing.Point(12, 82)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(697, 288)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            AddHandler Me.gridView1.MasterRowGetRelationName, New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(AddressOf Me.gridView1_MasterRowGetRelationName)
            AddHandler Me.gridView1.MasterRowGetChildList, New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(AddressOf Me.gridView1_MasterRowGetChildList)
            AddHandler Me.gridView1.MasterRowEmpty, New DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(AddressOf Me.gridView1_MasterRowEmpty)
            AddHandler Me.gridView1.MasterRowGetRelationCount, New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(AddressOf Me.gridView1_MasterRowGetRelationCount)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.textBox1)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(721, 466)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(24, 44)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(111, 22)
            Me.simpleButton1.StyleController = Me.layoutControl1
            Me.simpleButton1.TabIndex = 4
            Me.simpleButton1.Text = "reload focused detail"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlGroup2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(721, 466)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 70)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(701, 292)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(701, 70)
            Me.layoutControlGroup2.Text = "toolbar"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.simpleButton1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(115, 26)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(115, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(562, 26)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(12, 390)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(697, 64)
            Me.textBox1.TabIndex = 5
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.textBox1
            Me.layoutControlItem3.CustomizationFormText = "Log"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 362)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(701, 84)
            Me.layoutControlItem3.Text = "Log"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(17, 13)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(721, 466)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private textBox1 As System.Windows.Forms.TextBox

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
