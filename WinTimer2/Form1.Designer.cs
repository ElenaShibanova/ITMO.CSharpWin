
namespace WinTimer2
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
            this.customControlTimer21 = new WinTimer2.Properties.CustomControlTimer2();
            this.SuspendLayout();
            // 
            // customControlTimer21
            // 
            this.customControlTimer21.Location = new System.Drawing.Point(42, 28);
            this.customControlTimer21.Name = "customControlTimer21";
            this.customControlTimer21.Size = new System.Drawing.Size(75, 23);
            this.customControlTimer21.TabIndex = 1;
            this.customControlTimer21.Text = "customControlTimer21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.customControlTimer21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Properties.CustomControlTimer2 customControlTimer21;
    }
}

