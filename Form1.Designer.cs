
namespace Gestore_Cartelle
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_indirizzo = new System.Windows.Forms.TextBox();
            this.btn_crea = new System.Windows.Forms.Button();
            this.btn_annulla = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_elimina_elemento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(61, 27);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_forward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_forward.Location = new System.Drawing.Point(79, 12);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(61, 27);
            this.btn_forward.TabIndex = 1;
            this.btn_forward.Text = ">>>";
            this.btn_forward.UseVisualStyleBackColor = false;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(189, 12);
            this.txt_path.Multiline = true;
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(470, 26);
            this.txt_path.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 56);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(750, 363);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.Visible = false;
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_aggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aggiungi.Location = new System.Drawing.Point(665, 11);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(109, 27);
            this.btn_aggiungi.TabIndex = 5;
            this.btn_aggiungi.Text = "Aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = false;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // listbox1
            // 
            this.listbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 24;
            this.listbox1.Location = new System.Drawing.Point(45, 71);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(338, 340);
            this.listbox1.TabIndex = 6;
            this.listbox1.SelectedIndexChanged += new System.EventHandler(this.listbox1_SelectedIndexChanged);
            this.listbox1.DoubleClick += new System.EventHandler(this.listbox1_DoubleClick);
           
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(435, 95);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(146, 22);
            this.txt_nome.TabIndex = 7;
            this.txt_nome.Visible = false;
            this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);
            // 
            // txt_indirizzo
            // 
            this.txt_indirizzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_indirizzo.Location = new System.Drawing.Point(435, 133);
            this.txt_indirizzo.Name = "txt_indirizzo";
            this.txt_indirizzo.Size = new System.Drawing.Size(240, 22);
            this.txt_indirizzo.TabIndex = 8;
            this.txt_indirizzo.Visible = false;
            this.txt_indirizzo.Enter += new System.EventHandler(this.txt_indirizzo_Enter);
            // 
            // btn_crea
            // 
            this.btn_crea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crea.Location = new System.Drawing.Point(544, 168);
            this.btn_crea.Name = "btn_crea";
            this.btn_crea.Size = new System.Drawing.Size(68, 27);
            this.btn_crea.TabIndex = 9;
            this.btn_crea.Text = "Crea";
            this.btn_crea.UseVisualStyleBackColor = true;
            this.btn_crea.Visible = false;
            this.btn_crea.Click += new System.EventHandler(this.btn_crea_Click);
            // 
            // btn_annulla
            // 
            this.btn_annulla.Location = new System.Drawing.Point(457, 168);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.Size = new System.Drawing.Size(52, 27);
            this.btn_annulla.TabIndex = 10;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.UseVisualStyleBackColor = true;
            this.btn_annulla.Visible = false;
            this.btn_annulla.Click += new System.EventHandler(this.btn_annulla_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = global::Gestore_Cartelle.Properties.Resources.icona_home;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Location = new System.Drawing.Point(146, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(37, 39);
            this.btn_home.TabIndex = 11;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_elimina_elemento
            // 
            this.btn_elimina_elemento.BackColor = System.Drawing.Color.Salmon;
            this.btn_elimina_elemento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_elimina_elemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elimina_elemento.Location = new System.Drawing.Point(398, 384);
            this.btn_elimina_elemento.Name = "btn_elimina_elemento";
            this.btn_elimina_elemento.Size = new System.Drawing.Size(68, 27);
            this.btn_elimina_elemento.TabIndex = 12;
            this.btn_elimina_elemento.Text = "Elimina";
            this.btn_elimina_elemento.UseVisualStyleBackColor = false;
            this.btn_elimina_elemento.Visible = false;
            this.btn_elimina_elemento.Click += new System.EventHandler(this.btn_elimina_elemento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 434);
            this.Controls.Add(this.btn_elimina_elemento);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_annulla);
            this.Controls.Add(this.btn_crea);
            this.Controls.Add(this.txt_indirizzo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione cartelle";
            this.Load += new System.EventHandler(this.avvio);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_indirizzo;
        private System.Windows.Forms.Button btn_crea;
        private System.Windows.Forms.Button btn_annulla;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_elimina_elemento;
    }
}

