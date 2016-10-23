<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoutique
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpSelectItem = New System.Windows.Forms.GroupBox()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblColors = New System.Windows.Forms.Label()
        Me.lstColors = New System.Windows.Forms.ListBox()
        Me.grpCharm = New System.Windows.Forms.GroupBox()
        Me.chkStar = New System.Windows.Forms.CheckBox()
        Me.chkSnowflake = New System.Windows.Forms.CheckBox()
        Me.chkRabbit = New System.Windows.Forms.CheckBox()
        Me.chkFlower = New System.Windows.Forms.CheckBox()
        Me.chkDog = New System.Windows.Forms.CheckBox()
        Me.chkCat = New System.Windows.Forms.CheckBox()
        Me.grpCrocheted = New System.Windows.Forms.GroupBox()
        Me.radWrap = New System.Windows.Forms.RadioButton()
        Me.radScarf = New System.Windows.Forms.RadioButton()
        Me.radGlove = New System.Windows.Forms.RadioButton()
        Me.radHats = New System.Windows.Forms.RadioButton()
        Me.radCharm = New System.Windows.Forms.RadioButton()
        Me.radCrochted = New System.Windows.Forms.RadioButton()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblCart = New System.Windows.Forms.Label()
        Me.grpShipping = New System.Windows.Forms.GroupBox()
        Me.radNextDay = New System.Windows.Forms.RadioButton()
        Me.radPriority = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lstFinal = New System.Windows.Forms.ListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCheckoutOnly = New System.Windows.Forms.Button()
        Me.grpSelectItem.SuspendLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCharm.SuspendLayout()
        Me.grpCrocheted.SuspendLayout()
        Me.grpShipping.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSelectItem
        '
        Me.grpSelectItem.Controls.Add(Me.numQuantity)
        Me.grpSelectItem.Controls.Add(Me.lblQuantity)
        Me.grpSelectItem.Controls.Add(Me.lblColors)
        Me.grpSelectItem.Controls.Add(Me.lstColors)
        Me.grpSelectItem.Controls.Add(Me.grpCharm)
        Me.grpSelectItem.Controls.Add(Me.grpCrocheted)
        Me.grpSelectItem.Controls.Add(Me.radCharm)
        Me.grpSelectItem.Controls.Add(Me.radCrochted)
        Me.grpSelectItem.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectItem.Location = New System.Drawing.Point(11, 8)
        Me.grpSelectItem.Name = "grpSelectItem"
        Me.grpSelectItem.Size = New System.Drawing.Size(294, 379)
        Me.grpSelectItem.TabIndex = 0
        Me.grpSelectItem.TabStop = False
        Me.grpSelectItem.Text = "Please Select One"
        '
        'numQuantity
        '
        Me.numQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQuantity.Location = New System.Drawing.Point(226, 181)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(51, 26)
        Me.numQuantity.TabIndex = 8
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(151, 183)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity"
        '
        'lblColors
        '
        Me.lblColors.AutoSize = True
        Me.lblColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColors.Location = New System.Drawing.Point(153, 56)
        Me.lblColors.Name = "lblColors"
        Me.lblColors.Size = New System.Drawing.Size(54, 20)
        Me.lblColors.TabIndex = 5
        Me.lblColors.Text = "Colors"
        '
        'lstColors
        '
        Me.lstColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstColors.FormattingEnabled = True
        Me.lstColors.ItemHeight = 20
        Me.lstColors.Items.AddRange(New Object() {"Black", "Blue", "Gray", "Red", "White"})
        Me.lstColors.Location = New System.Drawing.Point(157, 83)
        Me.lstColors.Name = "lstColors"
        Me.lstColors.Size = New System.Drawing.Size(120, 84)
        Me.lstColors.Sorted = True
        Me.lstColors.TabIndex = 4
        '
        'grpCharm
        '
        Me.grpCharm.Controls.Add(Me.chkStar)
        Me.grpCharm.Controls.Add(Me.chkSnowflake)
        Me.grpCharm.Controls.Add(Me.chkRabbit)
        Me.grpCharm.Controls.Add(Me.chkFlower)
        Me.grpCharm.Controls.Add(Me.chkDog)
        Me.grpCharm.Controls.Add(Me.chkCat)
        Me.grpCharm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCharm.Location = New System.Drawing.Point(7, 255)
        Me.grpCharm.Name = "grpCharm"
        Me.grpCharm.Size = New System.Drawing.Size(281, 118)
        Me.grpCharm.TabIndex = 3
        Me.grpCharm.TabStop = False
        Me.grpCharm.Text = "Charms - $2 each -"
        '
        'chkStar
        '
        Me.chkStar.AutoSize = True
        Me.chkStar.Location = New System.Drawing.Point(150, 86)
        Me.chkStar.Name = "chkStar"
        Me.chkStar.Size = New System.Drawing.Size(65, 24)
        Me.chkStar.TabIndex = 5
        Me.chkStar.Text = "Star"
        Me.chkStar.UseVisualStyleBackColor = True
        '
        'chkSnowflake
        '
        Me.chkSnowflake.AutoSize = True
        Me.chkSnowflake.Location = New System.Drawing.Point(150, 56)
        Me.chkSnowflake.Name = "chkSnowflake"
        Me.chkSnowflake.Size = New System.Drawing.Size(109, 24)
        Me.chkSnowflake.TabIndex = 4
        Me.chkSnowflake.Text = "Snowflake"
        Me.chkSnowflake.UseVisualStyleBackColor = True
        '
        'chkRabbit
        '
        Me.chkRabbit.AutoSize = True
        Me.chkRabbit.Location = New System.Drawing.Point(150, 26)
        Me.chkRabbit.Name = "chkRabbit"
        Me.chkRabbit.Size = New System.Drawing.Size(82, 24)
        Me.chkRabbit.TabIndex = 3
        Me.chkRabbit.Text = "Rabbit"
        Me.chkRabbit.UseVisualStyleBackColor = True
        '
        'chkFlower
        '
        Me.chkFlower.AutoSize = True
        Me.chkFlower.Location = New System.Drawing.Point(6, 87)
        Me.chkFlower.Name = "chkFlower"
        Me.chkFlower.Size = New System.Drawing.Size(82, 24)
        Me.chkFlower.TabIndex = 2
        Me.chkFlower.Text = "Flower"
        Me.chkFlower.UseVisualStyleBackColor = True
        '
        'chkDog
        '
        Me.chkDog.AutoSize = True
        Me.chkDog.Location = New System.Drawing.Point(5, 56)
        Me.chkDog.Name = "chkDog"
        Me.chkDog.Size = New System.Drawing.Size(65, 24)
        Me.chkDog.TabIndex = 1
        Me.chkDog.Text = "Dog"
        Me.chkDog.UseVisualStyleBackColor = True
        '
        'chkCat
        '
        Me.chkCat.AutoSize = True
        Me.chkCat.Location = New System.Drawing.Point(5, 25)
        Me.chkCat.Name = "chkCat"
        Me.chkCat.Size = New System.Drawing.Size(60, 24)
        Me.chkCat.TabIndex = 0
        Me.chkCat.Text = "Cat"
        Me.chkCat.UseVisualStyleBackColor = True
        '
        'grpCrocheted
        '
        Me.grpCrocheted.Controls.Add(Me.radWrap)
        Me.grpCrocheted.Controls.Add(Me.radScarf)
        Me.grpCrocheted.Controls.Add(Me.radGlove)
        Me.grpCrocheted.Controls.Add(Me.radHats)
        Me.grpCrocheted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCrocheted.Location = New System.Drawing.Point(7, 56)
        Me.grpCrocheted.Name = "grpCrocheted"
        Me.grpCrocheted.Size = New System.Drawing.Size(138, 150)
        Me.grpCrocheted.TabIndex = 2
        Me.grpCrocheted.TabStop = False
        Me.grpCrocheted.Text = "Select One:"
        '
        'radWrap
        '
        Me.radWrap.AutoSize = True
        Me.radWrap.Location = New System.Drawing.Point(6, 117)
        Me.radWrap.Name = "radWrap"
        Me.radWrap.Size = New System.Drawing.Size(121, 24)
        Me.radWrap.TabIndex = 3
        Me.radWrap.TabStop = True
        Me.radWrap.Text = "Wrap - $25 -"
        Me.radWrap.UseVisualStyleBackColor = True
        '
        'radScarf
        '
        Me.radScarf.AutoSize = True
        Me.radScarf.Location = New System.Drawing.Point(6, 86)
        Me.radScarf.Name = "radScarf"
        Me.radScarf.Size = New System.Drawing.Size(121, 24)
        Me.radScarf.TabIndex = 2
        Me.radScarf.TabStop = True
        Me.radScarf.Text = "Scarf - $12 -"
        Me.radScarf.UseVisualStyleBackColor = True
        '
        'radGlove
        '
        Me.radGlove.AutoSize = True
        Me.radGlove.Location = New System.Drawing.Point(6, 56)
        Me.radGlove.Name = "radGlove"
        Me.radGlove.Size = New System.Drawing.Size(124, 24)
        Me.radGlove.TabIndex = 1
        Me.radGlove.TabStop = True
        Me.radGlove.Text = "Glove - $12 -"
        Me.radGlove.UseVisualStyleBackColor = True
        '
        'radHats
        '
        Me.radHats.AutoSize = True
        Me.radHats.Location = New System.Drawing.Point(6, 27)
        Me.radHats.Name = "radHats"
        Me.radHats.Size = New System.Drawing.Size(109, 24)
        Me.radHats.TabIndex = 0
        Me.radHats.TabStop = True
        Me.radHats.Text = "Hat - $10 -"
        Me.radHats.UseVisualStyleBackColor = True
        '
        'radCharm
        '
        Me.radCharm.AutoSize = True
        Me.radCharm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCharm.Location = New System.Drawing.Point(12, 225)
        Me.radCharm.Name = "radCharm"
        Me.radCharm.Size = New System.Drawing.Size(225, 26)
        Me.radCharm.TabIndex = 1
        Me.radCharm.TabStop = True
        Me.radCharm.Text = "Charm Bracelets - $10 -"
        Me.radCharm.UseVisualStyleBackColor = True
        '
        'radCrochted
        '
        Me.radCrochted.AutoSize = True
        Me.radCrochted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCrochted.Location = New System.Drawing.Point(12, 26)
        Me.radCrochted.Name = "radCrochted"
        Me.radCrochted.Size = New System.Drawing.Size(213, 26)
        Me.radCrochted.TabIndex = 0
        Me.radCrochted.TabStop = True
        Me.radCrochted.Text = "Hand Crocheted Items"
        Me.radCrochted.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Chocolate
        Me.btnContinue.Location = New System.Drawing.Point(326, 30)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(214, 33)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Add To Cart and Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.LightGreen
        Me.btnCheckout.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(638, 133)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(236, 52)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "Add To Cart and Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.HorizontalScrollbar = True
        Me.lstCart.ItemHeight = 20
        Me.lstCart.Location = New System.Drawing.Point(326, 150)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(214, 104)
        Me.lstCart.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Brown
        Me.btnDelete.Location = New System.Drawing.Point(385, 263)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblCart
        '
        Me.lblCart.AutoSize = True
        Me.lblCart.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCart.Location = New System.Drawing.Point(311, 120)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New System.Drawing.Size(248, 27)
        Me.lblCart.TabIndex = 6
        Me.lblCart.Text = "Your Shopping Cart"
        '
        'grpShipping
        '
        Me.grpShipping.Controls.Add(Me.radNextDay)
        Me.grpShipping.Controls.Add(Me.radPriority)
        Me.grpShipping.Controls.Add(Me.radStandard)
        Me.grpShipping.Font = New System.Drawing.Font("Lucida Handwriting", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpShipping.Location = New System.Drawing.Point(589, 21)
        Me.grpShipping.Name = "grpShipping"
        Me.grpShipping.Size = New System.Drawing.Size(324, 123)
        Me.grpShipping.TabIndex = 7
        Me.grpShipping.TabStop = False
        Me.grpShipping.Text = "Choose Shipping:"
        Me.grpShipping.Visible = False
        '
        'radNextDay
        '
        Me.radNextDay.AutoSize = True
        Me.radNextDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNextDay.Location = New System.Drawing.Point(7, 88)
        Me.radNextDay.Name = "radNextDay"
        Me.radNextDay.Size = New System.Drawing.Size(235, 24)
        Me.radNextDay.TabIndex = 2
        Me.radNextDay.TabStop = True
        Me.radNextDay.Text = "Next Day Shipping - $14.95 -"
        Me.radNextDay.UseVisualStyleBackColor = True
        Me.radNextDay.Visible = False
        '
        'radPriority
        '
        Me.radPriority.AutoSize = True
        Me.radPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPriority.Location = New System.Drawing.Point(7, 57)
        Me.radPriority.Name = "radPriority"
        Me.radPriority.Size = New System.Drawing.Size(291, 24)
        Me.radPriority.TabIndex = 1
        Me.radPriority.TabStop = True
        Me.radPriority.Text = "Priority Shipping (2 - 3 days) - $9.95 -"
        Me.radPriority.UseVisualStyleBackColor = True
        Me.radPriority.Visible = False
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.Location = New System.Drawing.Point(7, 26)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(310, 24)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard Shipping (5 - 7 days) - $2.95 -"
        Me.radStandard.UseVisualStyleBackColor = True
        Me.radStandard.Visible = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.Chocolate
        Me.btnTotal.Location = New System.Drawing.Point(692, 150)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(112, 29)
        Me.btnTotal.TabIndex = 8
        Me.btnTotal.Text = "Total Cost"
        Me.btnTotal.UseVisualStyleBackColor = False
        Me.btnTotal.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightGreen
        Me.btnSubmit.Location = New System.Drawing.Point(801, 333)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 29)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        Me.btnSubmit.Visible = False
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(440, 317)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 26)
        Me.txtSubtotal.TabIndex = 11
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Lucida Handwriting", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(326, 320)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(102, 21)
        Me.lblSubtotal.TabIndex = 12
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lstFinal
        '
        Me.lstFinal.FormattingEnabled = True
        Me.lstFinal.HorizontalScrollbar = True
        Me.lstFinal.ItemHeight = 20
        Me.lstFinal.Location = New System.Drawing.Point(589, 191)
        Me.lstFinal.Name = "lstFinal"
        Me.lstFinal.Size = New System.Drawing.Size(324, 124)
        Me.lstFinal.TabIndex = 13
        Me.lstFinal.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.Location = New System.Drawing.Point(589, 333)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 29)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Chocolate
        Me.btnBack.Location = New System.Drawing.Point(326, 51)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(214, 33)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'btnCheckoutOnly
        '
        Me.btnCheckoutOnly.BackColor = System.Drawing.Color.LightGreen
        Me.btnCheckoutOnly.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckoutOnly.Location = New System.Drawing.Point(638, 202)
        Me.btnCheckoutOnly.Name = "btnCheckoutOnly"
        Me.btnCheckoutOnly.Size = New System.Drawing.Size(236, 52)
        Me.btnCheckoutOnly.TabIndex = 3
        Me.btnCheckoutOnly.Text = "Checkout"
        Me.btnCheckoutOnly.UseVisualStyleBackColor = False
        '
        'frmBoutique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(943, 403)
        Me.Controls.Add(Me.btnCheckoutOnly)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lstFinal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.grpShipping)
        Me.Controls.Add(Me.lblCart)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.grpSelectItem)
        Me.Name = "frmBoutique"
        Me.Text = "The Handmade Boutique"
        Me.grpSelectItem.ResumeLayout(False)
        Me.grpSelectItem.PerformLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCharm.ResumeLayout(False)
        Me.grpCharm.PerformLayout()
        Me.grpCrocheted.ResumeLayout(False)
        Me.grpCrocheted.PerformLayout()
        Me.grpShipping.ResumeLayout(False)
        Me.grpShipping.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSelectItem As System.Windows.Forms.GroupBox
    Friend WithEvents grpCharm As System.Windows.Forms.GroupBox
    Friend WithEvents grpCrocheted As System.Windows.Forms.GroupBox
    Friend WithEvents radCharm As System.Windows.Forms.RadioButton
    Friend WithEvents radCrochted As System.Windows.Forms.RadioButton
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblColors As System.Windows.Forms.Label
    Friend WithEvents lstColors As System.Windows.Forms.ListBox
    Friend WithEvents radWrap As System.Windows.Forms.RadioButton
    Friend WithEvents radScarf As System.Windows.Forms.RadioButton
    Friend WithEvents radGlove As System.Windows.Forms.RadioButton
    Friend WithEvents radHats As System.Windows.Forms.RadioButton
    Friend WithEvents chkStar As System.Windows.Forms.CheckBox
    Friend WithEvents chkSnowflake As System.Windows.Forms.CheckBox
    Friend WithEvents chkRabbit As System.Windows.Forms.CheckBox
    Friend WithEvents chkFlower As System.Windows.Forms.CheckBox
    Friend WithEvents chkDog As System.Windows.Forms.CheckBox
    Friend WithEvents chkCat As System.Windows.Forms.CheckBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnCheckout As System.Windows.Forms.Button
    Friend WithEvents lstCart As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblCart As System.Windows.Forms.Label
    Friend WithEvents grpShipping As System.Windows.Forms.GroupBox
    Friend WithEvents radNextDay As System.Windows.Forms.RadioButton
    Friend WithEvents radPriority As System.Windows.Forms.RadioButton
    Friend WithEvents radStandard As System.Windows.Forms.RadioButton
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents numQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lstFinal As System.Windows.Forms.ListBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnCheckoutOnly As System.Windows.Forms.Button

End Class
