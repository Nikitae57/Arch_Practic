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
			this.listView1 = new System.Windows.Forms.ListView();
			this.point1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.point2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// firstPoint
			// 
			this.firstPoint.Location = new System.Drawing.Point(12, 25);
			this.firstPoint.Name = "firstPoint";
			this.firstPoint.Size = new System.Drawing.Size(122, 56);
			this.firstPoint.TabIndex = 0;
			this.firstPoint.TabStop = false;
			this.firstPoint.Text = "Точка 1";
			// 
			// secondPoint
			// 
			this.secondPoint.Location = new System.Drawing.Point(140, 25);
			this.secondPoint.Name = "secondPoint";
			this.secondPoint.Size = new System.Drawing.Size(122, 56);
			this.secondPoint.TabIndex = 1;
			this.secondPoint.TabStop = false;
			this.secondPoint.Text = "Точка 2";
			// 
			// Weight
			// 
			this.Weight.Location = new System.Drawing.Point(268, 25);
			this.Weight.Name = "Weight";
			this.Weight.Size = new System.Drawing.Size(122, 56);
			this.Weight.TabIndex = 2;
			this.Weight.TabStop = false;
			this.Weight.Text = "Вес";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.point1,
            this.point2,
            this.width});
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(12, 123);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(378, 325);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 562);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.Weight);
			this.Controls.Add(this.secondPoint);
			this.Controls.Add(this.firstPoint);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Practic";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox firstPoint;
		private System.Windows.Forms.GroupBox secondPoint;
		private System.Windows.Forms.GroupBox Weight;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader point1;
		private System.Windows.Forms.ColumnHeader point2;
		private System.Windows.Forms.ColumnHeader width;
	}
}

