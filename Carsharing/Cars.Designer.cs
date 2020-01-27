namespace Carsharing
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.Rent = new System.Windows.Forms.Button();
            this.carsGridView = new System.Windows.Forms.DataGridView();
            this.autoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsharingDataSet = new Carsharing.CarsharingDataSet();
            this.autoTableAdapter = new Carsharing.CarsharingDataSetTableAdapters.AutoTableAdapter();
            this.idautoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginecapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorAutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFuelCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinFuelCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuellevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsharingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Rent
            // 
            this.Rent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rent.Location = new System.Drawing.Point(22, 192);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(104, 62);
            this.Rent.TabIndex = 1;
            this.Rent.Text = "Арендовать";
            this.Rent.UseVisualStyleBackColor = false;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // carsGridView
            // 
            this.carsGridView.AllowUserToAddRows = false;
            this.carsGridView.AllowUserToDeleteRows = false;
            this.carsGridView.AutoGenerateColumns = false;
            this.carsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idautoDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.enginecapacityDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.transmissionDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.yearofissueDataGridViewTextBoxColumn,
            this.colorAutoDataGridViewTextBoxColumn,
            this.numFuelCardDataGridViewTextBoxColumn,
            this.pinFuelCardDataGridViewTextBoxColumn,
            this.serviceabilityDataGridViewTextBoxColumn,
            this.fuellevelDataGridViewTextBoxColumn,
            this.idworkerDataGridViewTextBoxColumn,
            this.idsupplyDataGridViewTextBoxColumn});
            this.carsGridView.DataSource = this.autoDataSetBindingSource;
            this.carsGridView.Location = new System.Drawing.Point(12, 12);
            this.carsGridView.Name = "carsGridView";
            this.carsGridView.ReadOnly = true;
            this.carsGridView.RowTemplate.Height = 24;
            this.carsGridView.Size = new System.Drawing.Size(623, 147);
            this.carsGridView.TabIndex = 10;
            // 
            // autoDataSetBindingSource
            // 
            this.autoDataSetBindingSource.DataMember = "Auto";
            this.autoDataSetBindingSource.DataSource = this.carsharingDataSet;
            // 
            // carsharingDataSet
            // 
            this.carsharingDataSet.DataSetName = "CarsharingDataSet";
            this.carsharingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // idautoDataGridViewTextBoxColumn
            // 
            this.idautoDataGridViewTextBoxColumn.DataPropertyName = "id_auto";
            this.idautoDataGridViewTextBoxColumn.HeaderText = "id_auto";
            this.idautoDataGridViewTextBoxColumn.Name = "idautoDataGridViewTextBoxColumn";
            this.idautoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idautoDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер машины";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 75;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enginecapacityDataGridViewTextBoxColumn
            // 
            this.enginecapacityDataGridViewTextBoxColumn.DataPropertyName = "Engine_capacity";
            this.enginecapacityDataGridViewTextBoxColumn.HeaderText = "Engine_capacity";
            this.enginecapacityDataGridViewTextBoxColumn.Name = "enginecapacityDataGridViewTextBoxColumn";
            this.enginecapacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.enginecapacityDataGridViewTextBoxColumn.Visible = false;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.Width = 80;
            // 
            // transmissionDataGridViewTextBoxColumn
            // 
            this.transmissionDataGridViewTextBoxColumn.DataPropertyName = "Transmission";
            this.transmissionDataGridViewTextBoxColumn.HeaderText = "Привод";
            this.transmissionDataGridViewTextBoxColumn.Name = "transmissionDataGridViewTextBoxColumn";
            this.transmissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.transmissionDataGridViewTextBoxColumn.Width = 80;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "Body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "Body";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodyDataGridViewTextBoxColumn.Visible = false;
            // 
            // yearofissueDataGridViewTextBoxColumn
            // 
            this.yearofissueDataGridViewTextBoxColumn.DataPropertyName = "Year_of_issue";
            this.yearofissueDataGridViewTextBoxColumn.HeaderText = "Year_of_issue";
            this.yearofissueDataGridViewTextBoxColumn.Name = "yearofissueDataGridViewTextBoxColumn";
            this.yearofissueDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearofissueDataGridViewTextBoxColumn.Visible = false;
            // 
            // colorAutoDataGridViewTextBoxColumn
            // 
            this.colorAutoDataGridViewTextBoxColumn.DataPropertyName = "ColorAuto";
            this.colorAutoDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.colorAutoDataGridViewTextBoxColumn.Name = "colorAutoDataGridViewTextBoxColumn";
            this.colorAutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorAutoDataGridViewTextBoxColumn.Width = 75;
            // 
            // numFuelCardDataGridViewTextBoxColumn
            // 
            this.numFuelCardDataGridViewTextBoxColumn.DataPropertyName = "NumFuelCard";
            this.numFuelCardDataGridViewTextBoxColumn.HeaderText = "NumFuelCard";
            this.numFuelCardDataGridViewTextBoxColumn.Name = "numFuelCardDataGridViewTextBoxColumn";
            this.numFuelCardDataGridViewTextBoxColumn.ReadOnly = true;
            this.numFuelCardDataGridViewTextBoxColumn.Visible = false;
            // 
            // pinFuelCardDataGridViewTextBoxColumn
            // 
            this.pinFuelCardDataGridViewTextBoxColumn.DataPropertyName = "PinFuelCard";
            this.pinFuelCardDataGridViewTextBoxColumn.HeaderText = "PinFuelCard";
            this.pinFuelCardDataGridViewTextBoxColumn.Name = "pinFuelCardDataGridViewTextBoxColumn";
            this.pinFuelCardDataGridViewTextBoxColumn.ReadOnly = true;
            this.pinFuelCardDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceabilityDataGridViewTextBoxColumn
            // 
            this.serviceabilityDataGridViewTextBoxColumn.DataPropertyName = "Serviceability";
            this.serviceabilityDataGridViewTextBoxColumn.HeaderText = "Serviceability";
            this.serviceabilityDataGridViewTextBoxColumn.Name = "serviceabilityDataGridViewTextBoxColumn";
            this.serviceabilityDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceabilityDataGridViewTextBoxColumn.Visible = false;
            // 
            // fuellevelDataGridViewTextBoxColumn
            // 
            this.fuellevelDataGridViewTextBoxColumn.DataPropertyName = "Fuel_level";
            this.fuellevelDataGridViewTextBoxColumn.HeaderText = "Уровень топлива";
            this.fuellevelDataGridViewTextBoxColumn.Name = "fuellevelDataGridViewTextBoxColumn";
            this.fuellevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.fuellevelDataGridViewTextBoxColumn.Width = 70;
            // 
            // idworkerDataGridViewTextBoxColumn
            // 
            this.idworkerDataGridViewTextBoxColumn.DataPropertyName = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.HeaderText = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.Name = "idworkerDataGridViewTextBoxColumn";
            this.idworkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idworkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // idsupplyDataGridViewTextBoxColumn
            // 
            this.idsupplyDataGridViewTextBoxColumn.DataPropertyName = "id_supply";
            this.idsupplyDataGridViewTextBoxColumn.HeaderText = "id_supply";
            this.idsupplyDataGridViewTextBoxColumn.Name = "idsupplyDataGridViewTextBoxColumn";
            this.idsupplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsupplyDataGridViewTextBoxColumn.Visible = false;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(636, 425);
            this.Controls.Add(this.carsGridView);
            this.Controls.Add(this.Rent);
            this.Name = "Cars";
            this.Text = "Выбор автомобиля";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsharingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.DataGridView carsGridView;
        private System.Windows.Forms.BindingSource autoDataSetBindingSource;
        private CarsharingDataSet carsharingDataSet;
        private CarsharingDataSetTableAdapters.AutoTableAdapter autoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idautoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginecapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorAutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFuelCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinFuelCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuellevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsupplyDataGridViewTextBoxColumn;
    }
}