namespace Arch_Practic
{
	partial class MainForm
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
            this.firstPoint = new System.Windows.Forms.GroupBox();
            this.secondPoint = new System.Windows.Forms.GroupBox();
            this.Weight = new System.Windows.Forms.GroupBox();
            this.tableEdges = new System.Windows.Forms.ListView();
            this.point1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.point2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textPoint1 = new System.Windows.Forms.TextBox();
            this.textPoint2 = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.bntDeleteEdge = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.minWeightLabel = new System.Windows.Forms.Label();
            this.minWeightValueLabel = new System.Windows.Forms.Label();
            this.textMinWay = new System.Windows.Forms.TextBox();
            this.btnFindSolution = new System.Windows.Forms.Button();
            this.firstPoint.SuspendLayout();
            this.secondPoint.SuspendLayout();
            this.Weight.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstPoint
            // 
            this.firstPoint.Controls.Add(this.textPoint1);
            this.firstPoint.Location = new System.Drawing.Point(16, 31);
            this.firstPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstPoint.Name = "firstPoint";
            this.firstPoint.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstPoint.Size = new System.Drawing.Size(163, 69);
            this.firstPoint.TabIndex = 0;
            this.firstPoint.TabStop = false;
            this.firstPoint.Text = "Точка 1";
            // 
            // secondPoint
            // 
            this.secondPoint.Controls.Add(this.textPoint2);
            this.secondPoint.Location = new System.Drawing.Point(187, 31);
            this.secondPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secondPoint.Name = "secondPoint";
            this.secondPoint.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secondPoint.Size = new System.Drawing.Size(163, 69);
            this.secondPoint.TabIndex = 1;
            this.secondPoint.TabStop = false;
            this.secondPoint.Text = "Точка 2";
            // 
            // Weight
            // 
            this.Weight.Controls.Add(this.textWeight);
            this.Weight.Location = new System.Drawing.Point(357, 31);
            this.Weight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Weight.Name = "Weight";
            this.Weight.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Weight.Size = new System.Drawing.Size(163, 69);
            this.Weight.TabIndex = 2;
            this.Weight.TabStop = false;
            this.Weight.Text = "Вес";
            // 
            // tableEdges
            // 
            this.tableEdges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.point1,
            this.point2,
            this.width});
            this.tableEdges.FullRowSelect = true;
            this.tableEdges.GridLines = true;
            this.tableEdges.Location = new System.Drawing.Point(16, 151);
            this.tableEdges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableEdges.MultiSelect = false;
            this.tableEdges.Name = "tableEdges";
            this.tableEdges.Size = new System.Drawing.Size(503, 399);
            this.tableEdges.TabIndex = 3;
            this.tableEdges.UseCompatibleStateImageBehavior = false;
            this.tableEdges.View = System.Windows.Forms.View.Details;
            // 
            // point1
            // 
            this.point1.Text = "Точка 1";
            this.point1.Width = 124;
            // 
            // point2
            // 
            this.point2.Text = "Точка 2";
            this.point2.Width = 124;
            // 
            // width
            // 
            this.width.Text = "Вес";
            this.width.Width = 126;
            // 
            // textPoint1
            // 
            this.textPoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPoint1.Location = new System.Drawing.Point(8, 23);
            this.textPoint1.MaxLength = 1;
            this.textPoint1.Name = "textPoint1";
            this.textPoint1.Size = new System.Drawing.Size(148, 34);
            this.textPoint1.TabIndex = 0;
            // 
            // textPoint2
            // 
            this.textPoint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPoint2.Location = new System.Drawing.Point(8, 23);
            this.textPoint2.MaxLength = 1;
            this.textPoint2.Name = "textPoint2";
            this.textPoint2.Size = new System.Drawing.Size(148, 34);
            this.textPoint2.TabIndex = 0;
            // 
            // textWeight
            // 
            this.textWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textWeight.Location = new System.Drawing.Point(8, 23);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(148, 34);
            this.textWeight.TabIndex = 0;
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(365, 108);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(153, 36);
            this.btnAddEdge.TabIndex = 4;
            this.btnAddEdge.Text = "Добавить";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.BtnAddEdge_Click);
            // 
            // bntDeleteEdge
            // 
            this.bntDeleteEdge.Location = new System.Drawing.Point(365, 558);
            this.bntDeleteEdge.Name = "bntDeleteEdge";
            this.bntDeleteEdge.Size = new System.Drawing.Size(152, 35);
            this.bntDeleteEdge.TabIndex = 5;
            this.bntDeleteEdge.Text = "Удалить";
            this.bntDeleteEdge.UseVisualStyleBackColor = true;
            this.bntDeleteEdge.Click += new System.EventHandler(this.BntDeleteEdge_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(16, 558);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(156, 35);
            this.btnDeleteAll.TabIndex = 6;
            this.btnDeleteAll.Text = "Удалить всё";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // minWeightLabel
            // 
            this.minWeightLabel.AutoSize = true;
            this.minWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minWeightLabel.Location = new System.Drawing.Point(18, 651);
            this.minWeightLabel.Name = "minWeightLabel";
            this.minWeightLabel.Size = new System.Drawing.Size(130, 32);
            this.minWeightLabel.TabIndex = 7;
            this.minWeightLabel.Text = "Мин. вес";
            // 
            // minWeightValueLabel
            // 
            this.minWeightValueLabel.AutoSize = true;
            this.minWeightValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minWeightValueLabel.Location = new System.Drawing.Point(154, 651);
            this.minWeightValueLabel.Name = "minWeightValueLabel";
            this.minWeightValueLabel.Size = new System.Drawing.Size(47, 32);
            this.minWeightValueLabel.TabIndex = 8;
            this.minWeightValueLabel.Text = "10";
            // 
            // textMinWay
            // 
            this.textMinWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMinWay.Location = new System.Drawing.Point(12, 614);
            this.textMinWay.Name = "textMinWay";
            this.textMinWay.ReadOnly = true;
            this.textMinWay.Size = new System.Drawing.Size(512, 34);
            this.textMinWay.TabIndex = 9;
            // 
            // btnFindSolution
            // 
            this.btnFindSolution.Location = new System.Drawing.Point(178, 558);
            this.btnFindSolution.Name = "btnFindSolution";
            this.btnFindSolution.Size = new System.Drawing.Size(181, 35);
            this.btnFindSolution.TabIndex = 10;
            this.btnFindSolution.Text = "Вычислить";
            this.btnFindSolution.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 692);
            this.Controls.Add(this.btnFindSolution);
            this.Controls.Add(this.textMinWay);
            this.Controls.Add(this.minWeightValueLabel);
            this.Controls.Add(this.minWeightLabel);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.bntDeleteEdge);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.tableEdges);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.secondPoint);
            this.Controls.Add(this.firstPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Practic";
            this.firstPoint.ResumeLayout(false);
            this.firstPoint.PerformLayout();
            this.secondPoint.ResumeLayout(false);
            this.secondPoint.PerformLayout();
            this.Weight.ResumeLayout(false);
            this.Weight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox firstPoint;
		private System.Windows.Forms.GroupBox secondPoint;
		private System.Windows.Forms.GroupBox Weight;
		private System.Windows.Forms.ListView tableEdges;
		private System.Windows.Forms.ColumnHeader point1;
		private System.Windows.Forms.ColumnHeader point2;
		private System.Windows.Forms.ColumnHeader width;
        private System.Windows.Forms.TextBox textPoint1;
        private System.Windows.Forms.TextBox textPoint2;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button bntDeleteEdge;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label minWeightLabel;
        private System.Windows.Forms.Label minWeightValueLabel;
        private System.Windows.Forms.TextBox textMinWay;
        private System.Windows.Forms.Button btnFindSolution;
    }
}

