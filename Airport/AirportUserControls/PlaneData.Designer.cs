namespace Airport
{
    partial class PlaneData
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.lblDeprecation = new System.Windows.Forms.Label();
            this.lblDeprecationValue = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.btnFly = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblRangeValue = new System.Windows.Forms.Label();
            this.lblMarketDaysValue = new System.Windows.Forms.Label();
            this.lblMarketContract = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlaneName
            // 
            this.lblPlaneName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlaneName.AutoSize = true;
            this.lblPlaneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlaneName.Location = new System.Drawing.Point(15, 14);
            this.lblPlaneName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaneName.MaximumSize = new System.Drawing.Size(200, 32);
            this.lblPlaneName.MinimumSize = new System.Drawing.Size(200, 32);
            this.lblPlaneName.Name = "lblPlaneName";
            this.lblPlaneName.Size = new System.Drawing.Size(200, 32);
            this.lblPlaneName.TabIndex = 1;
            this.lblPlaneName.Text = "PlaneName";
            this.lblPlaneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(17, 65);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.MaximumSize = new System.Drawing.Size(80, 0);
            this.lblCity.MinimumSize = new System.Drawing.Size(80, 20);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(80, 34);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Текущий город:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCityName
            // 
            this.lblCityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCityName.AutoSize = true;
            this.lblCityName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCityName.Location = new System.Drawing.Point(97, 65);
            this.lblCityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCityName.MaximumSize = new System.Drawing.Size(210, 40);
            this.lblCityName.MinimumSize = new System.Drawing.Size(210, 20);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(210, 20);
            this.lblCityName.TabIndex = 3;
            this.lblCityName.Text = "CityName";
            this.lblCityName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed.Location = new System.Drawing.Point(17, 114);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeed.MinimumSize = new System.Drawing.Size(65, 20);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(73, 20);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "Скорость:";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpeedValue.AutoSize = true;
            this.lblSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeedValue.Location = new System.Drawing.Point(111, 114);
            this.lblSpeedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeedValue.MaximumSize = new System.Drawing.Size(60, 20);
            this.lblSpeedValue.MinimumSize = new System.Drawing.Size(60, 20);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(60, 20);
            this.lblSpeedValue.TabIndex = 5;
            this.lblSpeedValue.Text = "Value";
            this.lblSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbCheck
            // 
            this.rbCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCheck.AutoSize = true;
            this.rbCheck.Location = new System.Drawing.Point(446, 14);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(14, 13);
            this.rbCheck.TabIndex = 6;
            this.rbCheck.TabStop = true;
            this.rbCheck.UseVisualStyleBackColor = true;
            // 
            // lblDeprecation
            // 
            this.lblDeprecation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeprecation.AutoSize = true;
            this.lblDeprecation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeprecation.Location = new System.Drawing.Point(181, 114);
            this.lblDeprecation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeprecation.MinimumSize = new System.Drawing.Size(63, 20);
            this.lblDeprecation.Name = "lblDeprecation";
            this.lblDeprecation.Size = new System.Drawing.Size(63, 20);
            this.lblDeprecation.TabIndex = 7;
            this.lblDeprecation.Text = "Износ:";
            this.lblDeprecation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeprecationValue
            // 
            this.lblDeprecationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeprecationValue.AutoSize = true;
            this.lblDeprecationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeprecationValue.Location = new System.Drawing.Point(387, 113);
            this.lblDeprecationValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeprecationValue.MaximumSize = new System.Drawing.Size(51, 20);
            this.lblDeprecationValue.MinimumSize = new System.Drawing.Size(51, 20);
            this.lblDeprecationValue.Name = "lblDeprecationValue";
            this.lblDeprecationValue.Size = new System.Drawing.Size(51, 20);
            this.lblDeprecationValue.TabIndex = 8;
            this.lblDeprecationValue.Text = "Value";
            this.lblDeprecationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeprecationValue.UseWaitCursor = true;
            // 
            // btnSell
            // 
            this.btnSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSell.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Location = new System.Drawing.Point(352, 109);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(116, 30);
            this.btnSell.TabIndex = 20;
            this.btnSell.Text = "Продать";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(374, 23);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.MaximumSize = new System.Drawing.Size(100, 20);
            this.lblPrice.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 20);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Цена:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceValue.Location = new System.Drawing.Point(374, 43);
            this.lblPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceValue.MaximumSize = new System.Drawing.Size(80, 20);
            this.lblPriceValue.MinimumSize = new System.Drawing.Size(80, 20);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(80, 20);
            this.lblPriceValue.TabIndex = 22;
            this.lblPriceValue.Text = "Value";
            this.lblPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(181, 85);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.MaximumSize = new System.Drawing.Size(44, 20);
            this.lblType.MinimumSize = new System.Drawing.Size(44, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 20);
            this.lblType.TabIndex = 23;
            this.lblType.Text = "Тип:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTypeValue.AutoSize = true;
            this.lblTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeValue.Location = new System.Drawing.Point(368, 84);
            this.lblTypeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeValue.MaximumSize = new System.Drawing.Size(80, 20);
            this.lblTypeValue.MinimumSize = new System.Drawing.Size(80, 20);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(80, 20);
            this.lblTypeValue.TabIndex = 24;
            this.lblTypeValue.Text = "Value";
            this.lblTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFly
            // 
            this.btnFly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFly.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFly.Location = new System.Drawing.Point(352, 13);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(113, 40);
            this.btnFly.TabIndex = 19;
            this.btnFly.Text = "Отправить";
            this.btnFly.UseVisualStyleBackColor = true;
            this.btnFly.Click += new System.EventHandler(this.BtnFly_Click);
            // 
            // lblMax
            // 
            this.lblMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMax.Location = new System.Drawing.Point(17, 55);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.MinimumSize = new System.Drawing.Size(65, 20);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(98, 20);
            this.lblMax.TabIndex = 59;
            this.lblMax.Text = "Вместимость:";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxValue.Location = new System.Drawing.Point(155, 55);
            this.lblMaxValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxValue.MaximumSize = new System.Drawing.Size(60, 20);
            this.lblMaxValue.MinimumSize = new System.Drawing.Size(60, 20);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(60, 20);
            this.lblMaxValue.TabIndex = 61;
            this.lblMaxValue.Text = "Value";
            this.lblMaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRange
            // 
            this.lblRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRange.Location = new System.Drawing.Point(17, 75);
            this.lblRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRange.MinimumSize = new System.Drawing.Size(65, 20);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(83, 20);
            this.lblRange.TabIndex = 62;
            this.lblRange.Text = "Дальность:";
            this.lblRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRangeValue
            // 
            this.lblRangeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRangeValue.AutoSize = true;
            this.lblRangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRangeValue.Location = new System.Drawing.Point(126, 75);
            this.lblRangeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRangeValue.MaximumSize = new System.Drawing.Size(60, 20);
            this.lblRangeValue.MinimumSize = new System.Drawing.Size(60, 20);
            this.lblRangeValue.Name = "lblRangeValue";
            this.lblRangeValue.Size = new System.Drawing.Size(60, 20);
            this.lblRangeValue.TabIndex = 63;
            this.lblRangeValue.Text = "Value";
            this.lblRangeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMarketDaysValue
            // 
            this.lblMarketDaysValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarketDaysValue.AutoSize = true;
            this.lblMarketDaysValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMarketDaysValue.Location = new System.Drawing.Point(388, 85);
            this.lblMarketDaysValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarketDaysValue.MaximumSize = new System.Drawing.Size(80, 20);
            this.lblMarketDaysValue.MinimumSize = new System.Drawing.Size(80, 20);
            this.lblMarketDaysValue.Name = "lblMarketDaysValue";
            this.lblMarketDaysValue.Size = new System.Drawing.Size(80, 20);
            this.lblMarketDaysValue.TabIndex = 64;
            this.lblMarketDaysValue.Text = "Value";
            this.lblMarketDaysValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMarketContract
            // 
            this.lblMarketContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarketContract.AutoSize = true;
            this.lblMarketContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMarketContract.Location = new System.Drawing.Point(181, 86);
            this.lblMarketContract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarketContract.MaximumSize = new System.Drawing.Size(65, 20);
            this.lblMarketContract.MinimumSize = new System.Drawing.Size(65, 20);
            this.lblMarketContract.Name = "lblMarketContract";
            this.lblMarketContract.Size = new System.Drawing.Size(65, 20);
            this.lblMarketContract.TabIndex = 65;
            this.lblMarketContract.Text = "Value:";
            this.lblMarketContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlaneData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMarketContract);
            this.Controls.Add(this.lblMarketDaysValue);
            this.Controls.Add(this.lblRangeValue);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTypeValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnFly);
            this.Controls.Add(this.lblDeprecationValue);
            this.Controls.Add(this.lblDeprecation);
            this.Controls.Add(this.rbCheck);
            this.Controls.Add(this.lblSpeedValue);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblPlaneName);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.lblCity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(480, 150);
            this.MinimumSize = new System.Drawing.Size(480, 150);
            this.Name = "PlaneData";
            this.Size = new System.Drawing.Size(478, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlaneName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.Label lblDeprecation;
        private System.Windows.Forms.Label lblDeprecationValue;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblRangeValue;
        private System.Windows.Forms.Label lblMarketDaysValue;
        private System.Windows.Forms.Label lblMarketContract;
    }
}
