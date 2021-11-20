
namespace KutuphaneYonetimSistemi.DesktopUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView3 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle5 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram6 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle6 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sayfalamaControl = new DevExpress.XtraTab.XtraTabControl();
            this.anasayfaTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jsonKtpTransfer = new DevExpress.XtraEditors.SimpleButton();
            this.excelUyeTransferBtn = new DevExpress.XtraEditors.SimpleButton();
            this.xmlUyeTransferBtn = new DevExpress.XtraEditors.SimpleButton();
            this.jsonUyeTransferBtn = new DevExpress.XtraEditors.SimpleButton();
            this.excelKitapTransferBtn = new DevExpress.XtraEditors.SimpleButton();
            this.xmlKitapTransferBtn = new DevExpress.XtraEditors.SimpleButton();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.kategoriTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kategoriKaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.kategoriSilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.kategoriGuncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KategoriAdiTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kategoriGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yazarTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.yazarEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.yazarSilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.yazarGuncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.yazarDetayTxt = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.yazarSoyadTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.yazarAdTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.yazarGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColYazar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdColYazar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoyadColYazar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DetayColYazar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kitapTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.ekleBtnKitap = new DevExpress.XtraEditors.SimpleButton();
            this.silBtnKitap = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtnKitap = new DevExpress.XtraEditors.SimpleButton();
            this.fotografLinkiTxtKitap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.yazarLookUpKitap = new DevExpress.XtraEditors.LookUpEdit();
            this.kategoriLookUpKitap = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.sayfaSayisiTxtKitap = new DevExpress.XtraEditors.TextEdit();
            this.yayinEviTxtKitap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.basimYiliTxtKitap = new DevExpress.XtraEditors.TextEdit();
            this.kitapAdiTxtKitap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.kitapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BasimYiliColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YayinEviColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SayfaSayisiColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurumColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kategoriColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yazarColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kitapFotoUrlColKitap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hareketTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ekleBtnHareket = new DevExpress.XtraEditors.SimpleButton();
            this.silBtnHareket = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtnHareket = new DevExpress.XtraEditors.SimpleButton();
            this.personelLookUpHareket = new DevExpress.XtraEditors.LookUpEdit();
            this.uyeLookUpHareket = new DevExpress.XtraEditors.LookUpEdit();
            this.kitapLookUpHareket = new DevExpress.XtraEditors.LookUpEdit();
            this.iadeTarihiDtHareket = new System.Windows.Forms.DateTimePicker();
            this.alisTarihiDtHareket = new System.Windows.Forms.DateTimePicker();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cezaDurumuLblHareket = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.gunFarkiLblHareket = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.hareketGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AlisTarihiColHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IadeTarihiColHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KitapColHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UyeColHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonelColHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cezaTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ekleBtnCeza = new DevExpress.XtraEditors.SimpleButton();
            this.silBtnCeza = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtnCeza = new DevExpress.XtraEditors.SimpleButton();
            this.hareketLookUpCeza = new DevExpress.XtraEditors.LookUpEdit();
            this.uyeLookUpCeza = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.button3 = new System.Windows.Forms.Button();
            this.paraTxtCeza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.bitisTarihiDtCeza = new System.Windows.Forms.DateTimePicker();
            this.baslangicTarihiDtCeza = new System.Windows.Forms.DateTimePicker();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cezaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColCeza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BaslangicTarihiColCeza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BitisTarihiColCeza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paraColCeza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uyeColCeza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hareketColCeza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uyeTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.adresTxtUye = new System.Windows.Forms.RichTextBox();
            this.ekleBtnUye = new DevExpress.XtraEditors.SimpleButton();
            this.silBtnUye = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtnUye = new DevExpress.XtraEditors.SimpleButton();
            this.tcknTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.okulTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.fotografTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.telefonTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.sifreTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.kullaniciAdiTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.mailTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.soyadTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.adTxtUye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.uyeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoyadColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mailColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kullaniciAdiColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sifreColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fotografColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telefonColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adresColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.okulColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TcknColUye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personelTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.duyuruTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.kasaTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.adTxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.soyadTxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.tcknTxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.sifreTxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.kullaniciAdiTxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.telefonTxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl40 = new DevExpress.XtraEditors.LabelControl();
            this.adresTxtPersonel = new System.Windows.Forms.RichTextBox();
            this.ekleBtnPersonel = new DevExpress.XtraEditors.SimpleButton();
            this.silBtnPersonel = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtnPersonel = new DevExpress.XtraEditors.SimpleButton();
            this.personelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdColPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoyadColPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TcknColPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelefonColPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdresColPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KullaniciAdiColPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sifreColPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.aciklamaTxtDuyuru = new System.Windows.Forms.RichTextBox();
            this.ekleBtnDuyuru = new DevExpress.XtraEditors.SimpleButton();
            this.silBtnDuyuru = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtnDuyuru = new DevExpress.XtraEditors.SimpleButton();
            this.duyuruGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColDuyuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AciklamaColDuyuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this.tutarTxtKasa = new DevExpress.XtraEditors.TextEdit();
            this.ekleBtnKasa = new DevExpress.XtraEditors.SimpleButton();
            this.silBtnKasa = new DevExpress.XtraEditors.SimpleButton();
            this.guncelleBtnKasa = new DevExpress.XtraEditors.SimpleButton();
            this.ayCbxKasa = new System.Windows.Forms.ComboBox();
            this.yilTxtKasa = new DevExpress.XtraEditors.TextEdit();
            this.kasaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColKasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AyColKasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YilColKasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TutarColKasa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sayfalamaControl)).BeginInit();
            this.sayfalamaControl.SuspendLayout();
            this.anasayfaTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            this.kategoriTabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriAdiTxt.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.yazarTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarSoyadTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarAdTxt.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.kitapTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografLinkiTxtKitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarLookUpKitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriLookUpKitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaSayisiTxtKitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinEviTxtKitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basimYiliTxtKitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAdiTxtKitap.Properties)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.hareketTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelLookUpHareket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeLookUpHareket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapLookUpHareket.Properties)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hareketGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.cezaTabPage.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hareketLookUpCeza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeLookUpCeza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paraTxtCeza.Properties)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cezaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.uyeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcknTxtUye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulTxtUye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotografTxtUye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTxtUye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTxtUye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdiTxtUye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxtUye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxtUye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTxtUye.Properties)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.personelTabPage.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.duyuruTabPage.SuspendLayout();
            this.kasaTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adTxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcknTxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdiTxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duyuruGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutarTxtKasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilTxtKasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            this.SuspendLayout();
            // 
            // sayfalamaControl
            // 
            this.sayfalamaControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sayfalamaControl.Location = new System.Drawing.Point(0, 0);
            this.sayfalamaControl.Name = "sayfalamaControl";
            this.sayfalamaControl.SelectedTabPage = this.anasayfaTabPage;
            this.sayfalamaControl.Size = new System.Drawing.Size(1159, 512);
            this.sayfalamaControl.TabIndex = 0;
            this.sayfalamaControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.anasayfaTabPage,
            this.kategoriTabPage,
            this.yazarTabPage,
            this.kitapTabPage,
            this.hareketTabPage,
            this.cezaTabPage,
            this.uyeTabPage,
            this.personelTabPage,
            this.duyuruTabPage,
            this.kasaTabPage});
            this.sayfalamaControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.sayfalamaControl_SelectedPageChanged);
            // 
            // anasayfaTabPage
            // 
            this.anasayfaTabPage.Controls.Add(this.groupBox2);
            this.anasayfaTabPage.Controls.Add(this.groupBox1);
            this.anasayfaTabPage.Controls.Add(this.chartControl2);
            this.anasayfaTabPage.Controls.Add(this.chartControl1);
            this.anasayfaTabPage.Name = "anasayfaTabPage";
            this.anasayfaTabPage.Size = new System.Drawing.Size(1153, 484);
            this.anasayfaTabPage.Text = "Anasayfa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(581, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Takvim";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(48, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jsonKtpTransfer);
            this.groupBox1.Controls.Add(this.excelUyeTransferBtn);
            this.groupBox1.Controls.Add(this.xmlUyeTransferBtn);
            this.groupBox1.Controls.Add(this.jsonUyeTransferBtn);
            this.groupBox1.Controls.Add(this.excelKitapTransferBtn);
            this.groupBox1.Controls.Add(this.xmlKitapTransferBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer İşlemleri";
            // 
            // jsonKtpTransfer
            // 
            this.jsonKtpTransfer.Location = new System.Drawing.Point(7, 132);
            this.jsonKtpTransfer.Name = "jsonKtpTransfer";
            this.jsonKtpTransfer.Size = new System.Drawing.Size(269, 48);
            this.jsonKtpTransfer.TabIndex = 6;
            this.jsonKtpTransfer.Text = "JSON Kitap Transfer";
            this.jsonKtpTransfer.Click += new System.EventHandler(this.Transfer_Buttons_Click);
            // 
            // excelUyeTransferBtn
            // 
            this.excelUyeTransferBtn.Location = new System.Drawing.Point(287, 75);
            this.excelUyeTransferBtn.Name = "excelUyeTransferBtn";
            this.excelUyeTransferBtn.Size = new System.Drawing.Size(270, 50);
            this.excelUyeTransferBtn.TabIndex = 4;
            this.excelUyeTransferBtn.Text = "Excel Üye Transfer";
            this.excelUyeTransferBtn.Click += new System.EventHandler(this.Transfer_Buttons_Click);
            // 
            // xmlUyeTransferBtn
            // 
            this.xmlUyeTransferBtn.Location = new System.Drawing.Point(287, 20);
            this.xmlUyeTransferBtn.Name = "xmlUyeTransferBtn";
            this.xmlUyeTransferBtn.Size = new System.Drawing.Size(270, 50);
            this.xmlUyeTransferBtn.TabIndex = 3;
            this.xmlUyeTransferBtn.Text = "XML Üye Transfer";
            this.xmlUyeTransferBtn.Click += new System.EventHandler(this.Transfer_Buttons_Click);
            // 
            // jsonUyeTransferBtn
            // 
            this.jsonUyeTransferBtn.Location = new System.Drawing.Point(287, 130);
            this.jsonUyeTransferBtn.Name = "jsonUyeTransferBtn";
            this.jsonUyeTransferBtn.Size = new System.Drawing.Size(270, 50);
            this.jsonUyeTransferBtn.TabIndex = 5;
            this.jsonUyeTransferBtn.Text = "JSON Üye Transfer";
            this.jsonUyeTransferBtn.Click += new System.EventHandler(this.Transfer_Buttons_Click);
            // 
            // excelKitapTransferBtn
            // 
            this.excelKitapTransferBtn.Location = new System.Drawing.Point(6, 75);
            this.excelKitapTransferBtn.Name = "excelKitapTransferBtn";
            this.excelKitapTransferBtn.Size = new System.Drawing.Size(270, 50);
            this.excelKitapTransferBtn.TabIndex = 1;
            this.excelKitapTransferBtn.Text = "Excel Kitap Transfer";
            this.excelKitapTransferBtn.Click += new System.EventHandler(this.Transfer_Buttons_Click);
            // 
            // xmlKitapTransferBtn
            // 
            this.xmlKitapTransferBtn.Location = new System.Drawing.Point(6, 20);
            this.xmlKitapTransferBtn.Name = "xmlKitapTransferBtn";
            this.xmlKitapTransferBtn.Size = new System.Drawing.Size(270, 50);
            this.xmlKitapTransferBtn.TabIndex = 0;
            this.xmlKitapTransferBtn.Text = "XML Kitap Transfer";
            this.xmlKitapTransferBtn.Click += new System.EventHandler(this.Transfer_Buttons_Click);
            // 
            // chartControl2
            // 
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram5;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(579, 3);
            this.chartControl2.Name = "chartControl2";
            series5.Name = "TL";
            series5.View = splineSeriesView3;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.chartControl2.Size = new System.Drawing.Size(564, 277);
            this.chartControl2.TabIndex = 1;
            chartTitle5.Text = "Ay-Gelir Grafiği";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle5});
            // 
            // chartControl1
            // 
            xyDiagram6.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram6.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram6;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(11, 3);
            this.chartControl1.Name = "chartControl1";
            series6.Name = "Adet";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series6};
            this.chartControl1.Size = new System.Drawing.Size(564, 277);
            this.chartControl1.TabIndex = 0;
            chartTitle6.Text = "Kategori-Kitap Grafiği";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle6});
            // 
            // kategoriTabPage
            // 
            this.kategoriTabPage.Controls.Add(this.groupBox4);
            this.kategoriTabPage.Controls.Add(this.groupBox3);
            this.kategoriTabPage.Name = "kategoriTabPage";
            this.kategoriTabPage.Size = new System.Drawing.Size(1153, 484);
            this.kategoriTabPage.Text = "Kategori İşlemleri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.kategoriKaydetBtn);
            this.groupBox4.Controls.Add(this.kategoriSilBtn);
            this.groupBox4.Controls.Add(this.kategoriGuncelleBtn);
            this.groupBox4.Controls.Add(this.KategoriAdiTxt);
            this.groupBox4.Controls.Add(this.labelControl1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1153, 137);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Veritabanı İşlemleri";
            // 
            // kategoriKaydetBtn
            // 
            this.kategoriKaydetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kategoriKaydetBtn.ImageOptions.Image")));
            this.kategoriKaydetBtn.Location = new System.Drawing.Point(834, 87);
            this.kategoriKaydetBtn.Name = "kategoriKaydetBtn";
            this.kategoriKaydetBtn.Size = new System.Drawing.Size(100, 43);
            this.kategoriKaydetBtn.TabIndex = 3;
            this.kategoriKaydetBtn.Text = "Ekle";
            this.kategoriKaydetBtn.Click += new System.EventHandler(this.Kategori_Vt_Bttns_Click);
            // 
            // kategoriSilBtn
            // 
            this.kategoriSilBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kategoriSilBtn.ImageOptions.Image")));
            this.kategoriSilBtn.Location = new System.Drawing.Point(1046, 87);
            this.kategoriSilBtn.Name = "kategoriSilBtn";
            this.kategoriSilBtn.Size = new System.Drawing.Size(100, 43);
            this.kategoriSilBtn.TabIndex = 3;
            this.kategoriSilBtn.Text = "Sil";
            this.kategoriSilBtn.Click += new System.EventHandler(this.Kategori_Vt_Bttns_Click);
            // 
            // kategoriGuncelleBtn
            // 
            this.kategoriGuncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kategoriGuncelleBtn.ImageOptions.Image")));
            this.kategoriGuncelleBtn.Location = new System.Drawing.Point(940, 87);
            this.kategoriGuncelleBtn.Name = "kategoriGuncelleBtn";
            this.kategoriGuncelleBtn.Size = new System.Drawing.Size(100, 43);
            this.kategoriGuncelleBtn.TabIndex = 3;
            this.kategoriGuncelleBtn.Text = "Güncelle";
            this.kategoriGuncelleBtn.Click += new System.EventHandler(this.Kategori_Vt_Bttns_Click);
            // 
            // KategoriAdiTxt
            // 
            this.KategoriAdiTxt.Location = new System.Drawing.Point(50, 36);
            this.KategoriAdiTxt.Name = "KategoriAdiTxt";
            this.KategoriAdiTxt.Size = new System.Drawing.Size(179, 20);
            this.KategoriAdiTxt.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ad :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kategoriGridControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1153, 347);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // kategoriGridControl
            // 
            this.kategoriGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kategoriGridControl.Location = new System.Drawing.Point(3, 17);
            this.kategoriGridControl.MainView = this.gridView1;
            this.kategoriGridControl.Name = "kategoriGridControl";
            this.kategoriGridControl.Size = new System.Drawing.Size(1147, 327);
            this.kategoriGridControl.TabIndex = 0;
            this.kategoriGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.Navy;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCol,
            this.AdCol});
            this.gridView1.GridControl = this.kategoriGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.kategoriGrid_Click);
            // 
            // IdCol
            // 
            this.IdCol.Caption = "Id";
            this.IdCol.FieldName = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.Visible = true;
            this.IdCol.VisibleIndex = 0;
            // 
            // AdCol
            // 
            this.AdCol.Caption = "Kategori Adı";
            this.AdCol.FieldName = "Ad";
            this.AdCol.Name = "AdCol";
            this.AdCol.Visible = true;
            this.AdCol.VisibleIndex = 1;
            // 
            // yazarTabPage
            // 
            this.yazarTabPage.Controls.Add(this.yazarEkleBtn);
            this.yazarTabPage.Controls.Add(this.yazarSilBtn);
            this.yazarTabPage.Controls.Add(this.yazarGuncelleBtn);
            this.yazarTabPage.Controls.Add(this.yazarDetayTxt);
            this.yazarTabPage.Controls.Add(this.labelControl4);
            this.yazarTabPage.Controls.Add(this.yazarSoyadTxt);
            this.yazarTabPage.Controls.Add(this.labelControl3);
            this.yazarTabPage.Controls.Add(this.yazarAdTxt);
            this.yazarTabPage.Controls.Add(this.labelControl2);
            this.yazarTabPage.Controls.Add(this.groupBox5);
            this.yazarTabPage.Name = "yazarTabPage";
            this.yazarTabPage.Size = new System.Drawing.Size(1153, 484);
            this.yazarTabPage.Text = "Yazar İşlemleri";
            // 
            // yazarEkleBtn
            // 
            this.yazarEkleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("yazarEkleBtn.ImageOptions.Image")));
            this.yazarEkleBtn.Location = new System.Drawing.Point(837, 434);
            this.yazarEkleBtn.Name = "yazarEkleBtn";
            this.yazarEkleBtn.Size = new System.Drawing.Size(100, 43);
            this.yazarEkleBtn.TabIndex = 8;
            this.yazarEkleBtn.Text = "Ekle";
            this.yazarEkleBtn.Click += new System.EventHandler(this.Yazar_Vt_Bttns_Click);
            // 
            // yazarSilBtn
            // 
            this.yazarSilBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("yazarSilBtn.ImageOptions.Image")));
            this.yazarSilBtn.Location = new System.Drawing.Point(1049, 434);
            this.yazarSilBtn.Name = "yazarSilBtn";
            this.yazarSilBtn.Size = new System.Drawing.Size(100, 43);
            this.yazarSilBtn.TabIndex = 9;
            this.yazarSilBtn.Text = "Sil";
            this.yazarSilBtn.Click += new System.EventHandler(this.Yazar_Vt_Bttns_Click);
            // 
            // yazarGuncelleBtn
            // 
            this.yazarGuncelleBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("yazarGuncelleBtn.ImageOptions.Image")));
            this.yazarGuncelleBtn.Location = new System.Drawing.Point(943, 434);
            this.yazarGuncelleBtn.Name = "yazarGuncelleBtn";
            this.yazarGuncelleBtn.Size = new System.Drawing.Size(100, 43);
            this.yazarGuncelleBtn.TabIndex = 10;
            this.yazarGuncelleBtn.Text = "Güncelle";
            this.yazarGuncelleBtn.Click += new System.EventHandler(this.Yazar_Vt_Bttns_Click);
            // 
            // yazarDetayTxt
            // 
            this.yazarDetayTxt.Location = new System.Drawing.Point(365, 364);
            this.yazarDetayTxt.Name = "yazarDetayTxt";
            this.yazarDetayTxt.Size = new System.Drawing.Size(227, 96);
            this.yazarDetayTxt.TabIndex = 7;
            this.yazarDetayTxt.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(300, 359);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Detay :";
            // 
            // yazarSoyadTxt
            // 
            this.yazarSoyadTxt.Location = new System.Drawing.Point(89, 394);
            this.yazarSoyadTxt.Name = "yazarSoyadTxt";
            this.yazarSoyadTxt.Size = new System.Drawing.Size(165, 20);
            this.yazarSoyadTxt.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 395);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Soyad :";
            // 
            // yazarAdTxt
            // 
            this.yazarAdTxt.Location = new System.Drawing.Point(89, 361);
            this.yazarAdTxt.Name = "yazarAdTxt";
            this.yazarAdTxt.Size = new System.Drawing.Size(165, 20);
            this.yazarAdTxt.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 359);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ad :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.yazarGridControl);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1153, 353);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // yazarGridControl
            // 
            this.yazarGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yazarGridControl.Location = new System.Drawing.Point(3, 17);
            this.yazarGridControl.MainView = this.gridView2;
            this.yazarGridControl.Name = "yazarGridControl";
            this.yazarGridControl.Size = new System.Drawing.Size(1147, 333);
            this.yazarGridControl.TabIndex = 0;
            this.yazarGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColYazar,
            this.AdColYazar,
            this.SoyadColYazar,
            this.DetayColYazar});
            this.gridView2.GridControl = this.yazarGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.Click += new System.EventHandler(this.gridView2_Click);
            // 
            // IdColYazar
            // 
            this.IdColYazar.Caption = "Id";
            this.IdColYazar.FieldName = "Id";
            this.IdColYazar.Name = "IdColYazar";
            this.IdColYazar.Visible = true;
            this.IdColYazar.VisibleIndex = 0;
            // 
            // AdColYazar
            // 
            this.AdColYazar.Caption = "Yazar Adı";
            this.AdColYazar.FieldName = "Ad";
            this.AdColYazar.Name = "AdColYazar";
            this.AdColYazar.Visible = true;
            this.AdColYazar.VisibleIndex = 1;
            // 
            // SoyadColYazar
            // 
            this.SoyadColYazar.Caption = "Yazar Soyadı";
            this.SoyadColYazar.FieldName = "Soyad";
            this.SoyadColYazar.Name = "SoyadColYazar";
            this.SoyadColYazar.Visible = true;
            this.SoyadColYazar.VisibleIndex = 2;
            // 
            // DetayColYazar
            // 
            this.DetayColYazar.Caption = "Yazar Detayı";
            this.DetayColYazar.FieldName = "Detay";
            this.DetayColYazar.Name = "DetayColYazar";
            this.DetayColYazar.Visible = true;
            this.DetayColYazar.VisibleIndex = 3;
            // 
            // kitapTabPage
            // 
            this.kitapTabPage.Controls.Add(this.ekleBtnKitap);
            this.kitapTabPage.Controls.Add(this.silBtnKitap);
            this.kitapTabPage.Controls.Add(this.guncelleBtnKitap);
            this.kitapTabPage.Controls.Add(this.fotografLinkiTxtKitap);
            this.kitapTabPage.Controls.Add(this.labelControl11);
            this.kitapTabPage.Controls.Add(this.yazarLookUpKitap);
            this.kitapTabPage.Controls.Add(this.kategoriLookUpKitap);
            this.kitapTabPage.Controls.Add(this.labelControl9);
            this.kitapTabPage.Controls.Add(this.labelControl10);
            this.kitapTabPage.Controls.Add(this.sayfaSayisiTxtKitap);
            this.kitapTabPage.Controls.Add(this.yayinEviTxtKitap);
            this.kitapTabPage.Controls.Add(this.labelControl7);
            this.kitapTabPage.Controls.Add(this.labelControl8);
            this.kitapTabPage.Controls.Add(this.basimYiliTxtKitap);
            this.kitapTabPage.Controls.Add(this.kitapAdiTxtKitap);
            this.kitapTabPage.Controls.Add(this.labelControl6);
            this.kitapTabPage.Controls.Add(this.labelControl5);
            this.kitapTabPage.Controls.Add(this.groupBox6);
            this.kitapTabPage.Name = "kitapTabPage";
            this.kitapTabPage.Size = new System.Drawing.Size(1153, 484);
            this.kitapTabPage.Text = "Kitap İşlemleri";
            // 
            // ekleBtnKitap
            // 
            this.ekleBtnKitap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtnKitap.ImageOptions.Image")));
            this.ekleBtnKitap.Location = new System.Drawing.Point(990, 385);
            this.ekleBtnKitap.Name = "ekleBtnKitap";
            this.ekleBtnKitap.Size = new System.Drawing.Size(100, 43);
            this.ekleBtnKitap.TabIndex = 14;
            this.ekleBtnKitap.Text = "Ekle";
            this.ekleBtnKitap.Click += new System.EventHandler(this.Kitap_Vt_Bttns_Click);
            // 
            // silBtnKitap
            // 
            this.silBtnKitap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtnKitap.ImageOptions.Image")));
            this.silBtnKitap.Location = new System.Drawing.Point(1046, 434);
            this.silBtnKitap.Name = "silBtnKitap";
            this.silBtnKitap.Size = new System.Drawing.Size(100, 43);
            this.silBtnKitap.TabIndex = 15;
            this.silBtnKitap.Text = "Sil";
            this.silBtnKitap.Click += new System.EventHandler(this.Kitap_Vt_Bttns_Click);
            // 
            // guncelleBtnKitap
            // 
            this.guncelleBtnKitap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtnKitap.ImageOptions.Image")));
            this.guncelleBtnKitap.Location = new System.Drawing.Point(940, 434);
            this.guncelleBtnKitap.Name = "guncelleBtnKitap";
            this.guncelleBtnKitap.Size = new System.Drawing.Size(100, 43);
            this.guncelleBtnKitap.TabIndex = 16;
            this.guncelleBtnKitap.Text = "Güncelle";
            this.guncelleBtnKitap.Click += new System.EventHandler(this.Kitap_Vt_Bttns_Click);
            // 
            // fotografLinkiTxtKitap
            // 
            this.fotografLinkiTxtKitap.Location = new System.Drawing.Point(408, 455);
            this.fotografLinkiTxtKitap.Name = "fotografLinkiTxtKitap";
            this.fotografLinkiTxtKitap.Size = new System.Drawing.Size(156, 20);
            this.fotografLinkiTxtKitap.TabIndex = 13;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(221, 453);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(172, 19);
            this.labelControl11.TabIndex = 12;
            this.labelControl11.Text = "Kitap Fotoğraf Linki :";
            // 
            // yazarLookUpKitap
            // 
            this.yazarLookUpKitap.Location = new System.Drawing.Point(697, 415);
            this.yazarLookUpKitap.Name = "yazarLookUpKitap";
            this.yazarLookUpKitap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.yazarLookUpKitap.Properties.DisplayMember = "Ad";
            this.yazarLookUpKitap.Properties.ValueMember = "Id";
            this.yazarLookUpKitap.Size = new System.Drawing.Size(152, 20);
            this.yazarLookUpKitap.TabIndex = 11;
            // 
            // kategoriLookUpKitap
            // 
            this.kategoriLookUpKitap.Location = new System.Drawing.Point(697, 371);
            this.kategoriLookUpKitap.Name = "kategoriLookUpKitap";
            this.kategoriLookUpKitap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kategoriLookUpKitap.Properties.DisplayMember = "Ad";
            this.kategoriLookUpKitap.Properties.ValueMember = "Id";
            this.kategoriLookUpKitap.Size = new System.Drawing.Size(152, 20);
            this.kategoriLookUpKitap.TabIndex = 11;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(621, 413);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 19);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Yazar :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(598, 369);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(81, 19);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Kategori :";
            // 
            // sayfaSayisiTxtKitap
            // 
            this.sayfaSayisiTxtKitap.Location = new System.Drawing.Point(408, 415);
            this.sayfaSayisiTxtKitap.Name = "sayfaSayisiTxtKitap";
            this.sayfaSayisiTxtKitap.Size = new System.Drawing.Size(156, 20);
            this.sayfaSayisiTxtKitap.TabIndex = 7;
            // 
            // yayinEviTxtKitap
            // 
            this.yayinEviTxtKitap.Location = new System.Drawing.Point(408, 369);
            this.yayinEviTxtKitap.Name = "yayinEviTxtKitap";
            this.yayinEviTxtKitap.Size = new System.Drawing.Size(156, 20);
            this.yayinEviTxtKitap.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(285, 413);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(108, 19);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Sayfa Sayısı :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(313, 369);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(80, 19);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Yayınevi :";
            // 
            // basimYiliTxtKitap
            // 
            this.basimYiliTxtKitap.Location = new System.Drawing.Point(103, 415);
            this.basimYiliTxtKitap.Name = "basimYiliTxtKitap";
            this.basimYiliTxtKitap.Size = new System.Drawing.Size(156, 20);
            this.basimYiliTxtKitap.TabIndex = 4;
            // 
            // kitapAdiTxtKitap
            // 
            this.kitapAdiTxtKitap.Location = new System.Drawing.Point(103, 371);
            this.kitapAdiTxtKitap.Name = "kitapAdiTxtKitap";
            this.kitapAdiTxtKitap.Size = new System.Drawing.Size(156, 20);
            this.kitapAdiTxtKitap.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 413);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 19);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Basım Yılı :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(11, 369);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 19);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Kitap Adı :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.kitapGridControl);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1153, 363);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // kitapGridControl
            // 
            this.kitapGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kitapGridControl.Location = new System.Drawing.Point(3, 17);
            this.kitapGridControl.MainView = this.gridView3;
            this.kitapGridControl.Name = "kitapGridControl";
            this.kitapGridControl.Size = new System.Drawing.Size(1147, 343);
            this.kitapGridControl.TabIndex = 0;
            this.kitapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColKitap,
            this.AdColKitap,
            this.BasimYiliColKitap,
            this.YayinEviColKitap,
            this.SayfaSayisiColKitap,
            this.DurumColKitap,
            this.kategoriColKitap,
            this.yazarColKitap,
            this.kitapFotoUrlColKitap});
            this.gridView3.GridControl = this.kitapGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.Click += new System.EventHandler(this.gridView3_Click);
            // 
            // IdColKitap
            // 
            this.IdColKitap.Caption = "Id";
            this.IdColKitap.FieldName = "Id";
            this.IdColKitap.Name = "IdColKitap";
            this.IdColKitap.Visible = true;
            this.IdColKitap.VisibleIndex = 0;
            // 
            // AdColKitap
            // 
            this.AdColKitap.Caption = "Kitap Adı";
            this.AdColKitap.FieldName = "Ad";
            this.AdColKitap.Name = "AdColKitap";
            this.AdColKitap.Visible = true;
            this.AdColKitap.VisibleIndex = 1;
            // 
            // BasimYiliColKitap
            // 
            this.BasimYiliColKitap.Caption = "Basım Yılı";
            this.BasimYiliColKitap.FieldName = "BasimYili";
            this.BasimYiliColKitap.Name = "BasimYiliColKitap";
            this.BasimYiliColKitap.Visible = true;
            this.BasimYiliColKitap.VisibleIndex = 2;
            // 
            // YayinEviColKitap
            // 
            this.YayinEviColKitap.Caption = "Yayınevi";
            this.YayinEviColKitap.FieldName = "YayinEvi";
            this.YayinEviColKitap.Name = "YayinEviColKitap";
            this.YayinEviColKitap.Visible = true;
            this.YayinEviColKitap.VisibleIndex = 3;
            // 
            // SayfaSayisiColKitap
            // 
            this.SayfaSayisiColKitap.Caption = "Sayfa Sayısı";
            this.SayfaSayisiColKitap.FieldName = "SayfaSayisi";
            this.SayfaSayisiColKitap.Name = "SayfaSayisiColKitap";
            this.SayfaSayisiColKitap.Visible = true;
            this.SayfaSayisiColKitap.VisibleIndex = 4;
            // 
            // DurumColKitap
            // 
            this.DurumColKitap.Caption = "Durum";
            this.DurumColKitap.FieldName = "Durum";
            this.DurumColKitap.Name = "DurumColKitap";
            this.DurumColKitap.Visible = true;
            this.DurumColKitap.VisibleIndex = 5;
            // 
            // kategoriColKitap
            // 
            this.kategoriColKitap.Caption = "Kategori";
            this.kategoriColKitap.FieldName = "Kategori";
            this.kategoriColKitap.Name = "kategoriColKitap";
            this.kategoriColKitap.Visible = true;
            this.kategoriColKitap.VisibleIndex = 6;
            // 
            // yazarColKitap
            // 
            this.yazarColKitap.Caption = "Yazar";
            this.yazarColKitap.FieldName = "Yazar";
            this.yazarColKitap.Name = "yazarColKitap";
            this.yazarColKitap.Visible = true;
            this.yazarColKitap.VisibleIndex = 7;
            // 
            // kitapFotoUrlColKitap
            // 
            this.kitapFotoUrlColKitap.Caption = "Kitap Fotoğraf Linki";
            this.kitapFotoUrlColKitap.FieldName = "KitapFotoUrl";
            this.kitapFotoUrlColKitap.Name = "kitapFotoUrlColKitap";
            this.kitapFotoUrlColKitap.Visible = true;
            this.kitapFotoUrlColKitap.VisibleIndex = 8;
            // 
            // hareketTabPage
            // 
            this.hareketTabPage.Controls.Add(this.button1);
            this.hareketTabPage.Controls.Add(this.ekleBtnHareket);
            this.hareketTabPage.Controls.Add(this.silBtnHareket);
            this.hareketTabPage.Controls.Add(this.guncelleBtnHareket);
            this.hareketTabPage.Controls.Add(this.personelLookUpHareket);
            this.hareketTabPage.Controls.Add(this.uyeLookUpHareket);
            this.hareketTabPage.Controls.Add(this.kitapLookUpHareket);
            this.hareketTabPage.Controls.Add(this.iadeTarihiDtHareket);
            this.hareketTabPage.Controls.Add(this.alisTarihiDtHareket);
            this.hareketTabPage.Controls.Add(this.labelControl13);
            this.hareketTabPage.Controls.Add(this.cezaDurumuLblHareket);
            this.hareketTabPage.Controls.Add(this.labelControl14);
            this.hareketTabPage.Controls.Add(this.labelControl18);
            this.hareketTabPage.Controls.Add(this.labelControl15);
            this.hareketTabPage.Controls.Add(this.labelControl17);
            this.hareketTabPage.Controls.Add(this.gunFarkiLblHareket);
            this.hareketTabPage.Controls.Add(this.labelControl16);
            this.hareketTabPage.Controls.Add(this.labelControl12);
            this.hareketTabPage.Controls.Add(this.groupBox7);
            this.hareketTabPage.Name = "hareketTabPage";
            this.hareketTabPage.Size = new System.Drawing.Size(1153, 484);
            this.hareketTabPage.Text = "Hareket İşlemleri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ekleBtnHareket
            // 
            this.ekleBtnHareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtnHareket.ImageOptions.Image")));
            this.ekleBtnHareket.Location = new System.Drawing.Point(990, 378);
            this.ekleBtnHareket.Name = "ekleBtnHareket";
            this.ekleBtnHareket.Size = new System.Drawing.Size(100, 43);
            this.ekleBtnHareket.TabIndex = 17;
            this.ekleBtnHareket.Text = "Ekle";
            this.ekleBtnHareket.Click += new System.EventHandler(this.Hareket_Vt_Bttns_Click);
            // 
            // silBtnHareket
            // 
            this.silBtnHareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtnHareket.ImageOptions.Image")));
            this.silBtnHareket.Location = new System.Drawing.Point(1046, 427);
            this.silBtnHareket.Name = "silBtnHareket";
            this.silBtnHareket.Size = new System.Drawing.Size(100, 43);
            this.silBtnHareket.TabIndex = 18;
            this.silBtnHareket.Text = "Sil";
            this.silBtnHareket.Click += new System.EventHandler(this.Hareket_Vt_Bttns_Click);
            // 
            // guncelleBtnHareket
            // 
            this.guncelleBtnHareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtnHareket.ImageOptions.Image")));
            this.guncelleBtnHareket.Location = new System.Drawing.Point(940, 427);
            this.guncelleBtnHareket.Name = "guncelleBtnHareket";
            this.guncelleBtnHareket.Size = new System.Drawing.Size(100, 43);
            this.guncelleBtnHareket.TabIndex = 19;
            this.guncelleBtnHareket.Text = "Güncelle";
            this.guncelleBtnHareket.Click += new System.EventHandler(this.Hareket_Vt_Bttns_Click);
            // 
            // personelLookUpHareket
            // 
            this.personelLookUpHareket.Location = new System.Drawing.Point(738, 387);
            this.personelLookUpHareket.Name = "personelLookUpHareket";
            this.personelLookUpHareket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.personelLookUpHareket.Properties.DisplayMember = "Ad";
            this.personelLookUpHareket.Properties.ValueMember = "Id";
            this.personelLookUpHareket.Size = new System.Drawing.Size(144, 20);
            this.personelLookUpHareket.TabIndex = 6;
            // 
            // uyeLookUpHareket
            // 
            this.uyeLookUpHareket.Location = new System.Drawing.Point(469, 424);
            this.uyeLookUpHareket.Name = "uyeLookUpHareket";
            this.uyeLookUpHareket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uyeLookUpHareket.Properties.DisplayMember = "Ad";
            this.uyeLookUpHareket.Properties.ValueMember = "Id";
            this.uyeLookUpHareket.Size = new System.Drawing.Size(144, 20);
            this.uyeLookUpHareket.TabIndex = 6;
            // 
            // kitapLookUpHareket
            // 
            this.kitapLookUpHareket.Location = new System.Drawing.Point(469, 385);
            this.kitapLookUpHareket.Name = "kitapLookUpHareket";
            this.kitapLookUpHareket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kitapLookUpHareket.Properties.DisplayMember = "Ad";
            this.kitapLookUpHareket.Properties.ValueMember = "Id";
            this.kitapLookUpHareket.Size = new System.Drawing.Size(144, 20);
            this.kitapLookUpHareket.TabIndex = 6;
            // 
            // iadeTarihiDtHareket
            // 
            this.iadeTarihiDtHareket.Location = new System.Drawing.Point(128, 421);
            this.iadeTarihiDtHareket.Name = "iadeTarihiDtHareket";
            this.iadeTarihiDtHareket.Size = new System.Drawing.Size(200, 21);
            this.iadeTarihiDtHareket.TabIndex = 5;
            // 
            // alisTarihiDtHareket
            // 
            this.alisTarihiDtHareket.Location = new System.Drawing.Point(128, 382);
            this.alisTarihiDtHareket.Name = "alisTarihiDtHareket";
            this.alisTarihiDtHareket.Size = new System.Drawing.Size(200, 21);
            this.alisTarihiDtHareket.TabIndex = 5;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(18, 382);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(94, 19);
            this.labelControl13.TabIndex = 4;
            this.labelControl13.Text = "Alış Tarihi :";
            // 
            // cezaDurumuLblHareket
            // 
            this.cezaDurumuLblHareket.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cezaDurumuLblHareket.Appearance.Options.UseFont = true;
            this.cezaDurumuLblHareket.Location = new System.Drawing.Point(469, 458);
            this.cezaDurumuLblHareket.Name = "cezaDurumuLblHareket";
            this.cezaDurumuLblHareket.Size = new System.Drawing.Size(30, 19);
            this.cezaDurumuLblHareket.TabIndex = 4;
            this.cezaDurumuLblHareket.Text = "null";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(333, 458);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(120, 19);
            this.labelControl14.TabIndex = 4;
            this.labelControl14.Text = "Ceza Durumu :";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(641, 388);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(82, 19);
            this.labelControl18.TabIndex = 4;
            this.labelControl18.Text = "Personel :";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(23, 458);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(89, 19);
            this.labelControl15.TabIndex = 4;
            this.labelControl15.Text = "Gün Farkı :";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(411, 421);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(42, 19);
            this.labelControl17.TabIndex = 4;
            this.labelControl17.Text = "Üye :";
            // 
            // gunFarkiLblHareket
            // 
            this.gunFarkiLblHareket.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunFarkiLblHareket.Appearance.Options.UseFont = true;
            this.gunFarkiLblHareket.Location = new System.Drawing.Point(128, 458);
            this.gunFarkiLblHareket.Name = "gunFarkiLblHareket";
            this.gunFarkiLblHareket.Size = new System.Drawing.Size(30, 19);
            this.gunFarkiLblHareket.TabIndex = 4;
            this.gunFarkiLblHareket.Text = "null";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(399, 382);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(54, 19);
            this.labelControl16.TabIndex = 4;
            this.labelControl16.Text = "Kitap :";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(11, 422);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(101, 19);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "İade Tarihi :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.hareketGridControl);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1153, 366);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // hareketGridControl
            // 
            this.hareketGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hareketGridControl.Location = new System.Drawing.Point(3, 17);
            this.hareketGridControl.MainView = this.gridView4;
            this.hareketGridControl.Name = "hareketGridControl";
            this.hareketGridControl.Size = new System.Drawing.Size(1147, 346);
            this.hareketGridControl.TabIndex = 0;
            this.hareketGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.Row.BackColor = System.Drawing.Color.Lime;
            this.gridView4.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView4.Appearance.Row.Options.UseBackColor = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColHareket,
            this.AlisTarihiColHareket,
            this.IadeTarihiColHareket,
            this.KitapColHareket,
            this.UyeColHareket,
            this.PersonelColHareket});
            this.gridView4.GridControl = this.hareketGridControl;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsBehavior.ReadOnly = true;
            this.gridView4.Click += new System.EventHandler(this.gridView4_Click);
            // 
            // IdColHareket
            // 
            this.IdColHareket.Caption = "Id";
            this.IdColHareket.FieldName = "Id";
            this.IdColHareket.Name = "IdColHareket";
            this.IdColHareket.Visible = true;
            this.IdColHareket.VisibleIndex = 0;
            // 
            // AlisTarihiColHareket
            // 
            this.AlisTarihiColHareket.Caption = "Alış Tarihi";
            this.AlisTarihiColHareket.FieldName = "AlisTarihi";
            this.AlisTarihiColHareket.Name = "AlisTarihiColHareket";
            this.AlisTarihiColHareket.Visible = true;
            this.AlisTarihiColHareket.VisibleIndex = 1;
            // 
            // IadeTarihiColHareket
            // 
            this.IadeTarihiColHareket.Caption = "İade Tarihi";
            this.IadeTarihiColHareket.FieldName = "IadeTarihi";
            this.IadeTarihiColHareket.Name = "IadeTarihiColHareket";
            this.IadeTarihiColHareket.Visible = true;
            this.IadeTarihiColHareket.VisibleIndex = 2;
            // 
            // KitapColHareket
            // 
            this.KitapColHareket.Caption = "Kitap";
            this.KitapColHareket.FieldName = "Kitap";
            this.KitapColHareket.Name = "KitapColHareket";
            this.KitapColHareket.Visible = true;
            this.KitapColHareket.VisibleIndex = 3;
            // 
            // UyeColHareket
            // 
            this.UyeColHareket.Caption = "Üye";
            this.UyeColHareket.FieldName = "Uye";
            this.UyeColHareket.Name = "UyeColHareket";
            this.UyeColHareket.Visible = true;
            this.UyeColHareket.VisibleIndex = 4;
            // 
            // PersonelColHareket
            // 
            this.PersonelColHareket.Caption = "Personel";
            this.PersonelColHareket.FieldName = "Personel";
            this.PersonelColHareket.Name = "PersonelColHareket";
            this.PersonelColHareket.Visible = true;
            this.PersonelColHareket.VisibleIndex = 5;
            // 
            // cezaTabPage
            // 
            this.cezaTabPage.Controls.Add(this.groupBox9);
            this.cezaTabPage.Controls.Add(this.groupBox8);
            this.cezaTabPage.Name = "cezaTabPage";
            this.cezaTabPage.Size = new System.Drawing.Size(1153, 484);
            this.cezaTabPage.Text = "Ceza İşlemleri";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ekleBtnCeza);
            this.groupBox9.Controls.Add(this.silBtnCeza);
            this.groupBox9.Controls.Add(this.guncelleBtnCeza);
            this.groupBox9.Controls.Add(this.hareketLookUpCeza);
            this.groupBox9.Controls.Add(this.uyeLookUpCeza);
            this.groupBox9.Controls.Add(this.labelControl23);
            this.groupBox9.Controls.Add(this.labelControl22);
            this.groupBox9.Controls.Add(this.button3);
            this.groupBox9.Controls.Add(this.paraTxtCeza);
            this.groupBox9.Controls.Add(this.labelControl21);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Controls.Add(this.bitisTarihiDtCeza);
            this.groupBox9.Controls.Add(this.baslangicTarihiDtCeza);
            this.groupBox9.Controls.Add(this.labelControl20);
            this.groupBox9.Controls.Add(this.labelControl19);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(0, 356);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1153, 128);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Veritabanı İşlemleri";
            // 
            // ekleBtnCeza
            // 
            this.ekleBtnCeza.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtnCeza.ImageOptions.Image")));
            this.ekleBtnCeza.Location = new System.Drawing.Point(991, 29);
            this.ekleBtnCeza.Name = "ekleBtnCeza";
            this.ekleBtnCeza.Size = new System.Drawing.Size(100, 43);
            this.ekleBtnCeza.TabIndex = 20;
            this.ekleBtnCeza.Text = "Ekle";
            this.ekleBtnCeza.Click += new System.EventHandler(this.ceza_Vt_Bttns_Click);
            // 
            // silBtnCeza
            // 
            this.silBtnCeza.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtnCeza.ImageOptions.Image")));
            this.silBtnCeza.Location = new System.Drawing.Point(1047, 78);
            this.silBtnCeza.Name = "silBtnCeza";
            this.silBtnCeza.Size = new System.Drawing.Size(100, 43);
            this.silBtnCeza.TabIndex = 21;
            this.silBtnCeza.Text = "Sil";
            this.silBtnCeza.Click += new System.EventHandler(this.ceza_Vt_Bttns_Click);
            // 
            // guncelleBtnCeza
            // 
            this.guncelleBtnCeza.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtnCeza.ImageOptions.Image")));
            this.guncelleBtnCeza.Location = new System.Drawing.Point(941, 78);
            this.guncelleBtnCeza.Name = "guncelleBtnCeza";
            this.guncelleBtnCeza.Size = new System.Drawing.Size(100, 43);
            this.guncelleBtnCeza.TabIndex = 22;
            this.guncelleBtnCeza.Text = "Güncelle";
            this.guncelleBtnCeza.Click += new System.EventHandler(this.ceza_Vt_Bttns_Click);
            // 
            // hareketLookUpCeza
            // 
            this.hareketLookUpCeza.Location = new System.Drawing.Point(563, 62);
            this.hareketLookUpCeza.Name = "hareketLookUpCeza";
            this.hareketLookUpCeza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hareketLookUpCeza.Properties.DisplayMember = "Ad";
            this.hareketLookUpCeza.Properties.ValueMember = "Id";
            this.hareketLookUpCeza.Size = new System.Drawing.Size(187, 20);
            this.hareketLookUpCeza.TabIndex = 12;
            // 
            // uyeLookUpCeza
            // 
            this.uyeLookUpCeza.Location = new System.Drawing.Point(563, 31);
            this.uyeLookUpCeza.Name = "uyeLookUpCeza";
            this.uyeLookUpCeza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uyeLookUpCeza.Properties.DisplayMember = "Ad";
            this.uyeLookUpCeza.Properties.ValueMember = "Id";
            this.uyeLookUpCeza.Size = new System.Drawing.Size(187, 20);
            this.uyeLookUpCeza.TabIndex = 12;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(468, 60);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(77, 19);
            this.labelControl23.TabIndex = 11;
            this.labelControl23.Text = "Hareket :";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(503, 28);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(42, 19);
            this.labelControl22.TabIndex = 11;
            this.labelControl22.Text = "Üye :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // paraTxtCeza
            // 
            this.paraTxtCeza.Location = new System.Drawing.Point(168, 90);
            this.paraTxtCeza.Name = "paraTxtCeza";
            this.paraTxtCeza.Size = new System.Drawing.Size(200, 20);
            this.paraTxtCeza.TabIndex = 9;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(103, 89);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(49, 19);
            this.labelControl21.TabIndex = 8;
            this.labelControl21.Text = "Para :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bitisTarihiDtCeza
            // 
            this.bitisTarihiDtCeza.Location = new System.Drawing.Point(168, 58);
            this.bitisTarihiDtCeza.Name = "bitisTarihiDtCeza";
            this.bitisTarihiDtCeza.Size = new System.Drawing.Size(200, 21);
            this.bitisTarihiDtCeza.TabIndex = 6;
            // 
            // baslangicTarihiDtCeza
            // 
            this.baslangicTarihiDtCeza.Location = new System.Drawing.Point(168, 28);
            this.baslangicTarihiDtCeza.Name = "baslangicTarihiDtCeza";
            this.baslangicTarihiDtCeza.Size = new System.Drawing.Size(200, 21);
            this.baslangicTarihiDtCeza.TabIndex = 6;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(52, 59);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(100, 19);
            this.labelControl20.TabIndex = 5;
            this.labelControl20.Text = "Bitiş Tarihi :";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(11, 29);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(141, 19);
            this.labelControl19.TabIndex = 5;
            this.labelControl19.Text = "Başlangıç Tarihi :";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cezaGridControl);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1153, 356);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // cezaGridControl
            // 
            this.cezaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cezaGridControl.Location = new System.Drawing.Point(3, 17);
            this.cezaGridControl.MainView = this.gridView5;
            this.cezaGridControl.Name = "cezaGridControl";
            this.cezaGridControl.Size = new System.Drawing.Size(1147, 336);
            this.cezaGridControl.TabIndex = 0;
            this.cezaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView5.Appearance.Row.BackColor2 = System.Drawing.Color.Red;
            this.gridView5.Appearance.Row.Options.UseBackColor = true;
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColCeza,
            this.BaslangicTarihiColCeza,
            this.BitisTarihiColCeza,
            this.paraColCeza,
            this.uyeColCeza,
            this.hareketColCeza});
            this.gridView5.GridControl = this.cezaGridControl;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsBehavior.ReadOnly = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.Click += new System.EventHandler(this.gridView5_Click);
            // 
            // IdColCeza
            // 
            this.IdColCeza.Caption = "Id";
            this.IdColCeza.FieldName = "Id";
            this.IdColCeza.Name = "IdColCeza";
            this.IdColCeza.Visible = true;
            this.IdColCeza.VisibleIndex = 0;
            // 
            // BaslangicTarihiColCeza
            // 
            this.BaslangicTarihiColCeza.Caption = "Başlangıç Tarihi";
            this.BaslangicTarihiColCeza.FieldName = "BaslangicTarihi";
            this.BaslangicTarihiColCeza.Name = "BaslangicTarihiColCeza";
            this.BaslangicTarihiColCeza.Visible = true;
            this.BaslangicTarihiColCeza.VisibleIndex = 1;
            // 
            // BitisTarihiColCeza
            // 
            this.BitisTarihiColCeza.Caption = "Bitiş Tarihi";
            this.BitisTarihiColCeza.FieldName = "BitisTarihi";
            this.BitisTarihiColCeza.Name = "BitisTarihiColCeza";
            this.BitisTarihiColCeza.Visible = true;
            this.BitisTarihiColCeza.VisibleIndex = 2;
            // 
            // paraColCeza
            // 
            this.paraColCeza.Caption = "Para";
            this.paraColCeza.FieldName = "Para";
            this.paraColCeza.Name = "paraColCeza";
            this.paraColCeza.Visible = true;
            this.paraColCeza.VisibleIndex = 3;
            // 
            // uyeColCeza
            // 
            this.uyeColCeza.Caption = "Üye";
            this.uyeColCeza.FieldName = "Uye";
            this.uyeColCeza.Name = "uyeColCeza";
            this.uyeColCeza.Visible = true;
            this.uyeColCeza.VisibleIndex = 4;
            // 
            // hareketColCeza
            // 
            this.hareketColCeza.Caption = "Hareket ID";
            this.hareketColCeza.FieldName = "Hareket";
            this.hareketColCeza.Name = "hareketColCeza";
            this.hareketColCeza.Visible = true;
            this.hareketColCeza.VisibleIndex = 5;
            // 
            // uyeTabPage
            // 
            this.uyeTabPage.Controls.Add(this.adresTxtUye);
            this.uyeTabPage.Controls.Add(this.ekleBtnUye);
            this.uyeTabPage.Controls.Add(this.silBtnUye);
            this.uyeTabPage.Controls.Add(this.guncelleBtnUye);
            this.uyeTabPage.Controls.Add(this.tcknTxtUye);
            this.uyeTabPage.Controls.Add(this.okulTxtUye);
            this.uyeTabPage.Controls.Add(this.fotografTxtUye);
            this.uyeTabPage.Controls.Add(this.telefonTxtUye);
            this.uyeTabPage.Controls.Add(this.sifreTxtUye);
            this.uyeTabPage.Controls.Add(this.labelControl32);
            this.uyeTabPage.Controls.Add(this.kullaniciAdiTxtUye);
            this.uyeTabPage.Controls.Add(this.labelControl31);
            this.uyeTabPage.Controls.Add(this.labelControl27);
            this.uyeTabPage.Controls.Add(this.labelControl33);
            this.uyeTabPage.Controls.Add(this.labelControl30);
            this.uyeTabPage.Controls.Add(this.labelControl28);
            this.uyeTabPage.Controls.Add(this.labelControl29);
            this.uyeTabPage.Controls.Add(this.mailTxtUye);
            this.uyeTabPage.Controls.Add(this.soyadTxtUye);
            this.uyeTabPage.Controls.Add(this.adTxtUye);
            this.uyeTabPage.Controls.Add(this.labelControl26);
            this.uyeTabPage.Controls.Add(this.labelControl25);
            this.uyeTabPage.Controls.Add(this.labelControl24);
            this.uyeTabPage.Controls.Add(this.groupBox10);
            this.uyeTabPage.Name = "uyeTabPage";
            this.uyeTabPage.Size = new System.Drawing.Size(1153, 484);
            this.uyeTabPage.Text = "Üye İşlemleri";
            // 
            // adresTxtUye
            // 
            this.adresTxtUye.Location = new System.Drawing.Point(765, 381);
            this.adresTxtUye.Name = "adresTxtUye";
            this.adresTxtUye.Size = new System.Drawing.Size(145, 78);
            this.adresTxtUye.TabIndex = 26;
            this.adresTxtUye.Text = "";
            // 
            // ekleBtnUye
            // 
            this.ekleBtnUye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtnUye.ImageOptions.Image")));
            this.ekleBtnUye.Location = new System.Drawing.Point(990, 378);
            this.ekleBtnUye.Name = "ekleBtnUye";
            this.ekleBtnUye.Size = new System.Drawing.Size(100, 43);
            this.ekleBtnUye.TabIndex = 23;
            this.ekleBtnUye.Text = "Ekle";
            this.ekleBtnUye.Click += new System.EventHandler(this.Uye_Vt_Bttns_Click);
            // 
            // silBtnUye
            // 
            this.silBtnUye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("silBtnUye.ImageOptions.Image")));
            this.silBtnUye.Location = new System.Drawing.Point(1046, 427);
            this.silBtnUye.Name = "silBtnUye";
            this.silBtnUye.Size = new System.Drawing.Size(100, 43);
            this.silBtnUye.TabIndex = 24;
            this.silBtnUye.Text = "Sil";
            this.silBtnUye.Click += new System.EventHandler(this.Uye_Vt_Bttns_Click);
            // 
            // guncelleBtnUye
            // 
            this.guncelleBtnUye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guncelleBtnUye.ImageOptions.Image")));
            this.guncelleBtnUye.Location = new System.Drawing.Point(940, 427);
            this.guncelleBtnUye.Name = "guncelleBtnUye";
            this.guncelleBtnUye.Size = new System.Drawing.Size(100, 43);
            this.guncelleBtnUye.TabIndex = 25;
            this.guncelleBtnUye.Text = "Güncelle";
            this.guncelleBtnUye.Click += new System.EventHandler(this.Uye_Vt_Bttns_Click);
            // 
            // tcknTxtUye
            // 
            this.tcknTxtUye.Location = new System.Drawing.Point(626, 439);
            this.tcknTxtUye.Name = "tcknTxtUye";
            this.tcknTxtUye.Size = new System.Drawing.Size(111, 20);
            this.tcknTxtUye.TabIndex = 11;
            // 
            // okulTxtUye
            // 
            this.okulTxtUye.Location = new System.Drawing.Point(626, 397);
            this.okulTxtUye.Name = "okulTxtUye";
            this.okulTxtUye.Size = new System.Drawing.Size(111, 20);
            this.okulTxtUye.TabIndex = 12;
            // 
            // fotografTxtUye
            // 
            this.fotografTxtUye.Location = new System.Drawing.Point(353, 439);
            this.fotografTxtUye.Name = "fotografTxtUye";
            this.fotografTxtUye.Size = new System.Drawing.Size(116, 20);
            this.fotografTxtUye.TabIndex = 11;
            // 
            // telefonTxtUye
            // 
            this.telefonTxtUye.Location = new System.Drawing.Point(626, 357);
            this.telefonTxtUye.Name = "telefonTxtUye";
            this.telefonTxtUye.Size = new System.Drawing.Size(111, 20);
            this.telefonTxtUye.TabIndex = 13;
            // 
            // sifreTxtUye
            // 
            this.sifreTxtUye.Location = new System.Drawing.Point(353, 397);
            this.sifreTxtUye.Name = "sifreTxtUye";
            this.sifreTxtUye.Size = new System.Drawing.Size(116, 20);
            this.sifreTxtUye.TabIndex = 12;
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl32.Appearance.Options.UseFont = true;
            this.labelControl32.Location = new System.Drawing.Point(490, 437);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(116, 19);
            this.labelControl32.TabIndex = 8;
            this.labelControl32.Text = "TC Kimlik No :";
            // 
            // kullaniciAdiTxtUye
            // 
            this.kullaniciAdiTxtUye.Location = new System.Drawing.Point(353, 357);
            this.kullaniciAdiTxtUye.Name = "kullaniciAdiTxtUye";
            this.kullaniciAdiTxtUye.Size = new System.Drawing.Size(116, 20);
            this.kullaniciAdiTxtUye.TabIndex = 13;
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl31.Appearance.Options.UseFont = true;
            this.labelControl31.Location = new System.Drawing.Point(558, 398);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(48, 19);
            this.labelControl31.TabIndex = 9;
            this.labelControl31.Text = "Okul :";
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Location = new System.Drawing.Point(254, 437);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(80, 19);
            this.labelControl27.TabIndex = 8;
            this.labelControl27.Text = "Fotoğraf :";
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl33.Appearance.Options.UseFont = true;
            this.labelControl33.Location = new System.Drawing.Point(765, 358);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(58, 19);
            this.labelControl33.TabIndex = 10;
            this.labelControl33.Text = "Adres :";
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Location = new System.Drawing.Point(533, 358);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(73, 19);
            this.labelControl30.TabIndex = 10;
            this.labelControl30.Text = "Telefon :";
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Location = new System.Drawing.Point(285, 398);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(49, 19);
            this.labelControl28.TabIndex = 9;
            this.labelControl28.Text = "Şifre :";
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Location = new System.Drawing.Point(222, 355);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(112, 19);
            this.labelControl29.TabIndex = 10;
            this.labelControl29.Text = "Kullanıcı Adı :";
            // 
            // mailTxtUye
            // 
            this.mailTxtUye.Location = new System.Drawing.Point(87, 439);
            this.mailTxtUye.Name = "mailTxtUye";
            this.mailTxtUye.Size = new System.Drawing.Size(120, 20);
            this.mailTxtUye.TabIndex = 7;
            // 
            // soyadTxtUye
            // 
            this.soyadTxtUye.Location = new System.Drawing.Point(87, 397);
            this.soyadTxtUye.Name = "soyadTxtUye";
            this.soyadTxtUye.Size = new System.Drawing.Size(120, 20);
            this.soyadTxtUye.TabIndex = 7;
            // 
            // adTxtUye
            // 
            this.adTxtUye.Location = new System.Drawing.Point(87, 357);
            this.adTxtUye.Name = "adTxtUye";
            this.adTxtUye.Size = new System.Drawing.Size(120, 20);
            this.adTxtUye.TabIndex = 7;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Location = new System.Drawing.Point(26, 437);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(45, 19);
            this.labelControl26.TabIndex = 6;
            this.labelControl26.Text = "Mail :";
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl25.Appearance.Options.UseFont = true;
            this.labelControl25.Location = new System.Drawing.Point(11, 395);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(60, 19);
            this.labelControl25.TabIndex = 6;
            this.labelControl25.Text = "Soyad :";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Location = new System.Drawing.Point(38, 355);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(33, 19);
            this.labelControl24.TabIndex = 6;
            this.labelControl24.Text = "Ad :";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.uyeGridControl);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1153, 336);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            // 
            // uyeGridControl
            // 
            this.uyeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uyeGridControl.Location = new System.Drawing.Point(3, 17);
            this.uyeGridControl.MainView = this.gridView6;
            this.uyeGridControl.Name = "uyeGridControl";
            this.uyeGridControl.Size = new System.Drawing.Size(1147, 316);
            this.uyeGridControl.TabIndex = 0;
            this.uyeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView6.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView6.Appearance.Row.Options.UseBackColor = true;
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColUye,
            this.AdColUye,
            this.SoyadColUye,
            this.mailColUye,
            this.kullaniciAdiColUye,
            this.sifreColUye,
            this.fotografColUye,
            this.telefonColUye,
            this.adresColUye,
            this.okulColUye,
            this.TcknColUye});
            this.gridView6.GridControl = this.uyeGridControl;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsBehavior.Editable = false;
            this.gridView6.OptionsBehavior.ReadOnly = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.Click += new System.EventHandler(this.gridView6_Click);
            // 
            // IdColUye
            // 
            this.IdColUye.Caption = "Id";
            this.IdColUye.FieldName = "Id";
            this.IdColUye.Name = "IdColUye";
            this.IdColUye.Visible = true;
            this.IdColUye.VisibleIndex = 0;
            // 
            // AdColUye
            // 
            this.AdColUye.Caption = "Ad";
            this.AdColUye.FieldName = "Ad";
            this.AdColUye.Name = "AdColUye";
            this.AdColUye.Visible = true;
            this.AdColUye.VisibleIndex = 1;
            // 
            // SoyadColUye
            // 
            this.SoyadColUye.Caption = "Soyad";
            this.SoyadColUye.FieldName = "Soyad";
            this.SoyadColUye.Name = "SoyadColUye";
            this.SoyadColUye.Visible = true;
            this.SoyadColUye.VisibleIndex = 2;
            // 
            // mailColUye
            // 
            this.mailColUye.Caption = "Mail";
            this.mailColUye.FieldName = "Mail";
            this.mailColUye.Name = "mailColUye";
            this.mailColUye.Visible = true;
            this.mailColUye.VisibleIndex = 3;
            // 
            // kullaniciAdiColUye
            // 
            this.kullaniciAdiColUye.Caption = "Kullanıcı Adı";
            this.kullaniciAdiColUye.FieldName = "KullaniciAdi";
            this.kullaniciAdiColUye.Name = "kullaniciAdiColUye";
            this.kullaniciAdiColUye.Visible = true;
            this.kullaniciAdiColUye.VisibleIndex = 4;
            // 
            // sifreColUye
            // 
            this.sifreColUye.Caption = "Şifre";
            this.sifreColUye.FieldName = "Sifre";
            this.sifreColUye.Name = "sifreColUye";
            this.sifreColUye.Visible = true;
            this.sifreColUye.VisibleIndex = 5;
            // 
            // fotografColUye
            // 
            this.fotografColUye.Caption = "Fotoğraf";
            this.fotografColUye.FieldName = "Fotograf";
            this.fotografColUye.Name = "fotografColUye";
            this.fotografColUye.Visible = true;
            this.fotografColUye.VisibleIndex = 6;
            // 
            // telefonColUye
            // 
            this.telefonColUye.Caption = "Telefon";
            this.telefonColUye.FieldName = "Telefon";
            this.telefonColUye.Name = "telefonColUye";
            this.telefonColUye.Visible = true;
            this.telefonColUye.VisibleIndex = 7;
            // 
            // adresColUye
            // 
            this.adresColUye.Caption = "Adres";
            this.adresColUye.FieldName = "Adres";
            this.adresColUye.Name = "adresColUye";
            this.adresColUye.Visible = true;
            this.adresColUye.VisibleIndex = 8;
            // 
            // okulColUye
            // 
            this.okulColUye.Caption = "Okul";
            this.okulColUye.FieldName = "Okul";
            this.okulColUye.Name = "okulColUye";
            this.okulColUye.Visible = true;
            this.okulColUye.VisibleIndex = 9;
            // 
            // TcknColUye
            // 
            this.TcknColUye.Caption = "TC Kimlik No";
            this.TcknColUye.FieldName = "Tckn";
            this.TcknColUye.Name = "TcknColUye";
            this.TcknColUye.Visible = true;
            this.TcknColUye.VisibleIndex = 10;
            // 
            // personelTabPage
            // 
            this.personelTabPage.Controls.Add(this.groupBox12);
            this.personelTabPage.Controls.Add(this.groupBox11);
            this.personelTabPage.Name = "personelTabPage";
            this.personelTabPage.Size = new System.Drawing.Size(1153, 484);
            this.personelTabPage.Text = "Personel İşlemleri";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.ekleBtnPersonel);
            this.groupBox12.Controls.Add(this.silBtnPersonel);
            this.groupBox12.Controls.Add(this.guncelleBtnPersonel);
            this.groupBox12.Controls.Add(this.adresTxtPersonel);
            this.groupBox12.Controls.Add(this.labelControl40);
            this.groupBox12.Controls.Add(this.sifreTxtPersonel);
            this.groupBox12.Controls.Add(this.kullaniciAdiTxtPersonel);
            this.groupBox12.Controls.Add(this.telefonTxtPersonel);
            this.groupBox12.Controls.Add(this.labelControl37);
            this.groupBox12.Controls.Add(this.labelControl38);
            this.groupBox12.Controls.Add(this.labelControl39);
            this.groupBox12.Controls.Add(this.tcknTxtPersonel);
            this.groupBox12.Controls.Add(this.soyadTxtPersonel);
            this.groupBox12.Controls.Add(this.adTxtPersonel);
            this.groupBox12.Controls.Add(this.labelControl36);
            this.groupBox12.Controls.Add(this.labelControl35);
            this.groupBox12.Controls.Add(this.labelControl34);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(0, 323);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1153, 161);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Veritabanı İşlemleri";
            // 
            // labelControl36
            // 
            this.labelControl36.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl36.Appearance.Options.UseFont = true;
            this.labelControl36.Location = new System.Drawing.Point(64, 69);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(60, 19);
            this.labelControl36.TabIndex = 7;
            this.labelControl36.Text = "Soyad :";
            // 
            // labelControl35
            // 
            this.labelControl35.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl35.Appearance.Options.UseFont = true;
            this.labelControl35.Location = new System.Drawing.Point(11, 110);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(113, 19);
            this.labelControl35.TabIndex = 7;
            this.labelControl35.Text = "Tc Kimlik No :";
            // 
            // labelControl34
            // 
            this.labelControl34.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl34.Appearance.Options.UseFont = true;
            this.labelControl34.Location = new System.Drawing.Point(91, 31);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(33, 19);
            this.labelControl34.TabIndex = 7;
            this.labelControl34.Text = "Ad :";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.personelGridControl);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox11.Location = new System.Drawing.Point(0, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1153, 323);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            // 
            // duyuruTabPage
            // 
            this.duyuruTabPage.Controls.Add(this.groupBox14);
            this.duyuruTabPage.Controls.Add(this.groupBox13);
            this.duyuruTabPage.Name = "duyuruTabPage";
            this.duyuruTabPage.Size = new System.Drawing.Size(1153, 484);
            this.duyuruTabPage.Text = "Duyuru İşlemleri";
            // 
            // kasaTabPage
            // 
            this.kasaTabPage.Controls.Add(this.ayCbxKasa);
            this.kasaTabPage.Controls.Add(this.ekleBtnKasa);
            this.kasaTabPage.Controls.Add(this.silBtnKasa);
            this.kasaTabPage.Controls.Add(this.guncelleBtnKasa);
            this.kasaTabPage.Controls.Add(this.yilTxtKasa);
            this.kasaTabPage.Controls.Add(this.tutarTxtKasa);
            this.kasaTabPage.Controls.Add(this.labelControl44);
            this.kasaTabPage.Controls.Add(this.labelControl43);
            this.kasaTabPage.Controls.Add(this.labelControl42);
            this.kasaTabPage.Controls.Add(this.groupBox15);
            this.kasaTabPage.Name = "kasaTabPage";
            this.kasaTabPage.Size = new System.Drawing.Size(1153, 484);
            this.kasaTabPage.Text = "Kasa İşlemleri";
            // 
            // adTxtPersonel
            // 
            this.adTxtPersonel.Location = new System.Drawing.Point(144, 33);
            this.adTxtPersonel.Name = "adTxtPersonel";
            this.adTxtPersonel.Size = new System.Drawing.Size(140, 20);
            this.adTxtPersonel.TabIndex = 8;
            // 
            // soyadTxtPersonel
            // 
            this.soyadTxtPersonel.Location = new System.Drawing.Point(144, 71);
            this.soyadTxtPersonel.Name = "soyadTxtPersonel";
            this.soyadTxtPersonel.Size = new System.Drawing.Size(140, 20);
            this.soyadTxtPersonel.TabIndex = 8;
            // 
            // tcknTxtPersonel
            // 
            this.tcknTxtPersonel.Location = new System.Drawing.Point(144, 112);
            this.tcknTxtPersonel.Name = "tcknTxtPersonel";
            this.tcknTxtPersonel.Size = new System.Drawing.Size(140, 20);
            this.tcknTxtPersonel.TabIndex = 8;
            // 
            // sifreTxtPersonel
            // 
            this.sifreTxtPersonel.Location = new System.Drawing.Point(467, 112);
            this.sifreTxtPersonel.Name = "sifreTxtPersonel";
            this.sifreTxtPersonel.Size = new System.Drawing.Size(140, 20);
            this.sifreTxtPersonel.TabIndex = 12;
            // 
            // kullaniciAdiTxtPersonel
            // 
            this.kullaniciAdiTxtPersonel.Location = new System.Drawing.Point(467, 71);
            this.kullaniciAdiTxtPersonel.Name = "kullaniciAdiTxtPersonel";
            this.kullaniciAdiTxtPersonel.Size = new System.Drawing.Size(140, 20);
            this.kullaniciAdiTxtPersonel.TabIndex = 13;
            // 
            // telefonTxtPersonel
            // 
            this.telefonTxtPersonel.Location = new System.Drawing.Point(467, 33);
            this.telefonTxtPersonel.Name = "telefonTxtPersonel";
            this.telefonTxtPersonel.Size = new System.Drawing.Size(140, 20);
            this.telefonTxtPersonel.TabIndex = 14;
            // 
            // labelControl37
            // 
            this.labelControl37.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl37.Appearance.Options.UseFont = true;
            this.labelControl37.Location = new System.Drawing.Point(335, 69);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(112, 19);
            this.labelControl37.TabIndex = 9;
            this.labelControl37.Text = "Kullanıcı Adı :";
            // 
            // labelControl38
            // 
            this.labelControl38.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl38.Appearance.Options.UseFont = true;
            this.labelControl38.Location = new System.Drawing.Point(398, 110);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(49, 19);
            this.labelControl38.TabIndex = 10;
            this.labelControl38.Text = "Şifre :";
            // 
            // labelControl39
            // 
            this.labelControl39.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl39.Appearance.Options.UseFont = true;
            this.labelControl39.Location = new System.Drawing.Point(374, 31);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(73, 19);
            this.labelControl39.TabIndex = 11;
            this.labelControl39.Text = "Telefon :";
            // 
            // labelControl40
            // 
            this.labelControl40.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl40.Appearance.Options.UseFont = true;
            this.labelControl40.Location = new System.Drawing.Point(654, 31);
            this.labelControl40.Name = "labelControl40";
            this.labelControl40.Size = new System.Drawing.Size(58, 19);
            this.labelControl40.TabIndex = 15;
            this.labelControl40.Text = "Adres :";
            // 
            // adresTxtPersonel
            // 
            this.adresTxtPersonel.Location = new System.Drawing.Point(654, 56);
            this.adresTxtPersonel.Name = "adresTxtPersonel";
            this.adresTxtPersonel.Size = new System.Drawing.Size(172, 76);
            this.adresTxtPersonel.TabIndex = 16;
            this.adresTxtPersonel.Text = "";
            // 
            // ekleBtnPersonel
            // 
            this.ekleBtnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.ekleBtnPersonel.Location = new System.Drawing.Point(990, 51);
            this.ekleBtnPersonel.Name = "ekleBtnPersonel";
            this.ekleBtnPersonel.Size = new System.Drawing.Size(100, 43);
            this.ekleBtnPersonel.TabIndex = 26;
            this.ekleBtnPersonel.Text = "Ekle";
            this.ekleBtnPersonel.Click += new System.EventHandler(this.Personel_Vt_Bttns_Click);
            // 
            // silBtnPersonel
            // 
            this.silBtnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.silBtnPersonel.Location = new System.Drawing.Point(1046, 100);
            this.silBtnPersonel.Name = "silBtnPersonel";
            this.silBtnPersonel.Size = new System.Drawing.Size(100, 43);
            this.silBtnPersonel.TabIndex = 27;
            this.silBtnPersonel.Text = "Sil";
            this.silBtnPersonel.Click += new System.EventHandler(this.Personel_Vt_Bttns_Click);
            // 
            // guncelleBtnPersonel
            // 
            this.guncelleBtnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.guncelleBtnPersonel.Location = new System.Drawing.Point(940, 100);
            this.guncelleBtnPersonel.Name = "guncelleBtnPersonel";
            this.guncelleBtnPersonel.Size = new System.Drawing.Size(100, 43);
            this.guncelleBtnPersonel.TabIndex = 28;
            this.guncelleBtnPersonel.Text = "Güncelle";
            this.guncelleBtnPersonel.Click += new System.EventHandler(this.Personel_Vt_Bttns_Click);
            // 
            // personelGridControl
            // 
            this.personelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personelGridControl.Location = new System.Drawing.Point(3, 17);
            this.personelGridControl.MainView = this.gridView7;
            this.personelGridControl.Name = "personelGridControl";
            this.personelGridControl.Size = new System.Drawing.Size(1147, 303);
            this.personelGridControl.TabIndex = 0;
            this.personelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView7.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView7.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gridView7.Appearance.Row.Options.UseBackColor = true;
            this.gridView7.Appearance.Row.Options.UseBorderColor = true;
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColPersonel,
            this.AdColPersonel,
            this.SoyadColPersonel,
            this.TcknColPersonel,
            this.TelefonColPersonel,
            this.AdresColPersonel,
            this.KullaniciAdiColPersonel,
            this.sifreColPersonel});
            this.gridView7.GridControl = this.personelGridControl;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsBehavior.Editable = false;
            this.gridView7.OptionsBehavior.ReadOnly = true;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            this.gridView7.Click += new System.EventHandler(this.gridView7_Click);
            // 
            // IdColPersonel
            // 
            this.IdColPersonel.Caption = "Id";
            this.IdColPersonel.FieldName = "Id";
            this.IdColPersonel.Name = "IdColPersonel";
            this.IdColPersonel.Visible = true;
            this.IdColPersonel.VisibleIndex = 0;
            // 
            // AdColPersonel
            // 
            this.AdColPersonel.Caption = "Ad";
            this.AdColPersonel.FieldName = "Ad";
            this.AdColPersonel.Name = "AdColPersonel";
            this.AdColPersonel.Visible = true;
            this.AdColPersonel.VisibleIndex = 1;
            // 
            // SoyadColPersonel
            // 
            this.SoyadColPersonel.Caption = "Soyad";
            this.SoyadColPersonel.FieldName = "Soyad";
            this.SoyadColPersonel.Name = "SoyadColPersonel";
            this.SoyadColPersonel.Visible = true;
            this.SoyadColPersonel.VisibleIndex = 2;
            // 
            // TcknColPersonel
            // 
            this.TcknColPersonel.Caption = "Tc Kimlik No";
            this.TcknColPersonel.FieldName = "Tckn";
            this.TcknColPersonel.Name = "TcknColPersonel";
            this.TcknColPersonel.Visible = true;
            this.TcknColPersonel.VisibleIndex = 3;
            // 
            // TelefonColPersonel
            // 
            this.TelefonColPersonel.Caption = "Telefon";
            this.TelefonColPersonel.FieldName = "Telefon";
            this.TelefonColPersonel.Name = "TelefonColPersonel";
            this.TelefonColPersonel.Visible = true;
            this.TelefonColPersonel.VisibleIndex = 4;
            // 
            // AdresColPersonel
            // 
            this.AdresColPersonel.Caption = "Adres";
            this.AdresColPersonel.FieldName = "Adres";
            this.AdresColPersonel.Name = "AdresColPersonel";
            this.AdresColPersonel.Visible = true;
            this.AdresColPersonel.VisibleIndex = 5;
            // 
            // KullaniciAdiColPersonel
            // 
            this.KullaniciAdiColPersonel.Caption = "Kullanıcı Adı";
            this.KullaniciAdiColPersonel.FieldName = "KullaniciAdi";
            this.KullaniciAdiColPersonel.Name = "KullaniciAdiColPersonel";
            this.KullaniciAdiColPersonel.Visible = true;
            this.KullaniciAdiColPersonel.VisibleIndex = 6;
            // 
            // sifreColPersonel
            // 
            this.sifreColPersonel.Caption = "Şifre";
            this.sifreColPersonel.FieldName = "Sifre";
            this.sifreColPersonel.Name = "sifreColPersonel";
            this.sifreColPersonel.Visible = true;
            this.sifreColPersonel.VisibleIndex = 7;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.duyuruGridControl);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Location = new System.Drawing.Point(0, 0);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1153, 312);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.ekleBtnDuyuru);
            this.groupBox14.Controls.Add(this.silBtnDuyuru);
            this.groupBox14.Controls.Add(this.guncelleBtnDuyuru);
            this.groupBox14.Controls.Add(this.aciklamaTxtDuyuru);
            this.groupBox14.Controls.Add(this.labelControl41);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(0, 312);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1153, 172);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Veritabanı İşlemleri";
            // 
            // labelControl41
            // 
            this.labelControl41.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl41.Appearance.Options.UseFont = true;
            this.labelControl41.Location = new System.Drawing.Point(11, 31);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(120, 19);
            this.labelControl41.TabIndex = 8;
            this.labelControl41.Text = "Duyuru Metni :";
            // 
            // aciklamaTxtDuyuru
            // 
            this.aciklamaTxtDuyuru.Location = new System.Drawing.Point(11, 56);
            this.aciklamaTxtDuyuru.Name = "aciklamaTxtDuyuru";
            this.aciklamaTxtDuyuru.Size = new System.Drawing.Size(566, 96);
            this.aciklamaTxtDuyuru.TabIndex = 9;
            this.aciklamaTxtDuyuru.Text = "";
            // 
            // ekleBtnDuyuru
            // 
            this.ekleBtnDuyuru.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.ekleBtnDuyuru.Location = new System.Drawing.Point(990, 73);
            this.ekleBtnDuyuru.Name = "ekleBtnDuyuru";
            this.ekleBtnDuyuru.Size = new System.Drawing.Size(100, 43);
            this.ekleBtnDuyuru.TabIndex = 29;
            this.ekleBtnDuyuru.Text = "Ekle";
            this.ekleBtnDuyuru.Click += new System.EventHandler(this.Duyuru_Vt_Bttns_Click);
            // 
            // silBtnDuyuru
            // 
            this.silBtnDuyuru.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image1")));
            this.silBtnDuyuru.Location = new System.Drawing.Point(1046, 122);
            this.silBtnDuyuru.Name = "silBtnDuyuru";
            this.silBtnDuyuru.Size = new System.Drawing.Size(100, 43);
            this.silBtnDuyuru.TabIndex = 30;
            this.silBtnDuyuru.Text = "Sil";
            this.silBtnDuyuru.Click += new System.EventHandler(this.Duyuru_Vt_Bttns_Click);
            // 
            // guncelleBtnDuyuru
            // 
            this.guncelleBtnDuyuru.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image1")));
            this.guncelleBtnDuyuru.Location = new System.Drawing.Point(940, 122);
            this.guncelleBtnDuyuru.Name = "guncelleBtnDuyuru";
            this.guncelleBtnDuyuru.Size = new System.Drawing.Size(100, 43);
            this.guncelleBtnDuyuru.TabIndex = 31;
            this.guncelleBtnDuyuru.Text = "Güncelle";
            this.guncelleBtnDuyuru.Click += new System.EventHandler(this.Duyuru_Vt_Bttns_Click);
            // 
            // duyuruGridControl
            // 
            this.duyuruGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duyuruGridControl.Location = new System.Drawing.Point(3, 17);
            this.duyuruGridControl.MainView = this.gridView8;
            this.duyuruGridControl.Name = "duyuruGridControl";
            this.duyuruGridControl.Size = new System.Drawing.Size(1147, 292);
            this.duyuruGridControl.TabIndex = 0;
            this.duyuruGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView8});
            // 
            // gridView8
            // 
            this.gridView8.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView8.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView8.Appearance.Row.Options.UseBackColor = true;
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColDuyuru,
            this.AciklamaColDuyuru});
            this.gridView8.GridControl = this.duyuruGridControl;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsBehavior.Editable = false;
            this.gridView8.OptionsBehavior.ReadOnly = true;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            this.gridView8.Click += new System.EventHandler(this.gridView8_Click);
            // 
            // IdColDuyuru
            // 
            this.IdColDuyuru.Caption = "Id";
            this.IdColDuyuru.FieldName = "Id";
            this.IdColDuyuru.Name = "IdColDuyuru";
            this.IdColDuyuru.Visible = true;
            this.IdColDuyuru.VisibleIndex = 0;
            // 
            // AciklamaColDuyuru
            // 
            this.AciklamaColDuyuru.Caption = "Açıklama";
            this.AciklamaColDuyuru.FieldName = "Aciklama";
            this.AciklamaColDuyuru.Name = "AciklamaColDuyuru";
            this.AciklamaColDuyuru.Visible = true;
            this.AciklamaColDuyuru.VisibleIndex = 1;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.kasaGridControl);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Location = new System.Drawing.Point(0, 0);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1153, 307);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            // 
            // labelControl42
            // 
            this.labelControl42.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl42.Appearance.Options.UseFont = true;
            this.labelControl42.Location = new System.Drawing.Point(35, 332);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(32, 19);
            this.labelControl42.TabIndex = 8;
            this.labelControl42.Text = "Ay :";
            // 
            // labelControl43
            // 
            this.labelControl43.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl43.Appearance.Options.UseFont = true;
            this.labelControl43.Location = new System.Drawing.Point(35, 377);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(32, 19);
            this.labelControl43.TabIndex = 8;
            this.labelControl43.Text = "Yıl :";
            // 
            // labelControl44
            // 
            this.labelControl44.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl44.Appearance.Options.UseFont = true;
            this.labelControl44.Location = new System.Drawing.Point(11, 420);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(56, 19);
            this.labelControl44.TabIndex = 8;
            this.labelControl44.Text = "Tutar :";
            // 
            // tutarTxtKasa
            // 
            this.tutarTxtKasa.Location = new System.Drawing.Point(87, 422);
            this.tutarTxtKasa.Name = "tutarTxtKasa";
            this.tutarTxtKasa.Size = new System.Drawing.Size(144, 20);
            this.tutarTxtKasa.TabIndex = 9;
            // 
            // ekleBtnKasa
            // 
            this.ekleBtnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image2")));
            this.ekleBtnKasa.Location = new System.Drawing.Point(990, 376);
            this.ekleBtnKasa.Name = "ekleBtnKasa";
            this.ekleBtnKasa.Size = new System.Drawing.Size(100, 43);
            this.ekleBtnKasa.TabIndex = 29;
            this.ekleBtnKasa.Text = "Ekle";
            this.ekleBtnKasa.Click += new System.EventHandler(this.Kasa_Vt_Bttns_Click);
            // 
            // silBtnKasa
            // 
            this.silBtnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image2")));
            this.silBtnKasa.Location = new System.Drawing.Point(1046, 425);
            this.silBtnKasa.Name = "silBtnKasa";
            this.silBtnKasa.Size = new System.Drawing.Size(100, 43);
            this.silBtnKasa.TabIndex = 30;
            this.silBtnKasa.Text = "Sil";
            this.silBtnKasa.Click += new System.EventHandler(this.Kasa_Vt_Bttns_Click);
            // 
            // guncelleBtnKasa
            // 
            this.guncelleBtnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image2")));
            this.guncelleBtnKasa.Location = new System.Drawing.Point(940, 425);
            this.guncelleBtnKasa.Name = "guncelleBtnKasa";
            this.guncelleBtnKasa.Size = new System.Drawing.Size(100, 43);
            this.guncelleBtnKasa.TabIndex = 31;
            this.guncelleBtnKasa.Text = "Güncelle";
            this.guncelleBtnKasa.Click += new System.EventHandler(this.Kasa_Vt_Bttns_Click);
            // 
            // ayCbxKasa
            // 
            this.ayCbxKasa.FormattingEnabled = true;
            this.ayCbxKasa.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.ayCbxKasa.Location = new System.Drawing.Point(87, 334);
            this.ayCbxKasa.Name = "ayCbxKasa";
            this.ayCbxKasa.Size = new System.Drawing.Size(144, 21);
            this.ayCbxKasa.TabIndex = 32;
            // 
            // yilTxtKasa
            // 
            this.yilTxtKasa.EditValue = "2021";
            this.yilTxtKasa.Location = new System.Drawing.Point(87, 379);
            this.yilTxtKasa.Name = "yilTxtKasa";
            this.yilTxtKasa.Properties.ReadOnly = true;
            this.yilTxtKasa.Size = new System.Drawing.Size(144, 20);
            this.yilTxtKasa.TabIndex = 9;
            // 
            // kasaGridControl
            // 
            this.kasaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kasaGridControl.Location = new System.Drawing.Point(3, 17);
            this.kasaGridControl.MainView = this.gridView9;
            this.kasaGridControl.Name = "kasaGridControl";
            this.kasaGridControl.Size = new System.Drawing.Size(1147, 287);
            this.kasaGridControl.TabIndex = 0;
            this.kasaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView9});
            // 
            // gridView9
            // 
            this.gridView9.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView9.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView9.Appearance.Row.Options.UseBackColor = true;
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColKasa,
            this.AyColKasa,
            this.YilColKasa,
            this.TutarColKasa});
            this.gridView9.GridControl = this.kasaGridControl;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsBehavior.Editable = false;
            this.gridView9.OptionsBehavior.ReadOnly = true;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            this.gridView9.Click += new System.EventHandler(this.gridView9_Click);
            // 
            // IdColKasa
            // 
            this.IdColKasa.Caption = "Id";
            this.IdColKasa.FieldName = "Id";
            this.IdColKasa.Name = "IdColKasa";
            this.IdColKasa.Visible = true;
            this.IdColKasa.VisibleIndex = 0;
            // 
            // AyColKasa
            // 
            this.AyColKasa.Caption = "Ay";
            this.AyColKasa.FieldName = "Ay";
            this.AyColKasa.Name = "AyColKasa";
            this.AyColKasa.Visible = true;
            this.AyColKasa.VisibleIndex = 1;
            // 
            // YilColKasa
            // 
            this.YilColKasa.Caption = "Yıl";
            this.YilColKasa.FieldName = "Yil";
            this.YilColKasa.Name = "YilColKasa";
            this.YilColKasa.OptionsColumn.AllowEdit = false;
            this.YilColKasa.Visible = true;
            this.YilColKasa.VisibleIndex = 2;
            // 
            // TutarColKasa
            // 
            this.TutarColKasa.Caption = "Tutar";
            this.TutarColKasa.FieldName = "Tutar";
            this.TutarColKasa.Name = "TutarColKasa";
            this.TutarColKasa.Visible = true;
            this.TutarColKasa.VisibleIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 512);
            this.Controls.Add(this.sayfalamaControl);
            this.Name = "Form1";
            this.Text = "Huzur Kütüphanesi Yönetim Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sayfalamaControl)).EndInit();
            this.sayfalamaControl.ResumeLayout(false);
            this.anasayfaTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.kategoriTabPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriAdiTxt.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.yazarTabPage.ResumeLayout(false);
            this.yazarTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yazarSoyadTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarAdTxt.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yazarGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.kitapTabPage.ResumeLayout(false);
            this.kitapTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografLinkiTxtKitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarLookUpKitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriLookUpKitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaSayisiTxtKitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinEviTxtKitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basimYiliTxtKitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAdiTxtKitap.Properties)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kitapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.hareketTabPage.ResumeLayout(false);
            this.hareketTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelLookUpHareket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeLookUpHareket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapLookUpHareket.Properties)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hareketGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.cezaTabPage.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hareketLookUpCeza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeLookUpCeza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paraTxtCeza.Properties)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cezaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.uyeTabPage.ResumeLayout(false);
            this.uyeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcknTxtUye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulTxtUye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotografTxtUye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTxtUye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTxtUye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdiTxtUye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxtUye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxtUye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adTxtUye.Properties)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uyeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.personelTabPage.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.duyuruTabPage.ResumeLayout(false);
            this.kasaTabPage.ResumeLayout(false);
            this.kasaTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adTxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcknTxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreTxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAdiTxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duyuruGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tutarTxtKasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilTxtKasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl sayfalamaControl;
        private DevExpress.XtraTab.XtraTabPage anasayfaTabPage;
        private DevExpress.XtraTab.XtraTabPage kategoriTabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton jsonUyeTransferBtn;
        private DevExpress.XtraEditors.SimpleButton excelUyeTransferBtn;
        private DevExpress.XtraEditors.SimpleButton xmlUyeTransferBtn;
        private DevExpress.XtraEditors.SimpleButton excelKitapTransferBtn;
        private DevExpress.XtraEditors.SimpleButton xmlKitapTransferBtn;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.SimpleButton jsonKtpTransfer;
        private DevExpress.XtraTab.XtraTabPage yazarTabPage;
        private DevExpress.XtraTab.XtraTabPage kitapTabPage;
        private DevExpress.XtraTab.XtraTabPage hareketTabPage;
        private DevExpress.XtraTab.XtraTabPage cezaTabPage;
        private DevExpress.XtraTab.XtraTabPage uyeTabPage;
        private DevExpress.XtraTab.XtraTabPage personelTabPage;
        private DevExpress.XtraTab.XtraTabPage duyuruTabPage;
        private DevExpress.XtraTab.XtraTabPage kasaTabPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl kategoriGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton kategoriKaydetBtn;
        private DevExpress.XtraEditors.SimpleButton kategoriSilBtn;
        private DevExpress.XtraEditors.SimpleButton kategoriGuncelleBtn;
        private DevExpress.XtraEditors.TextEdit KategoriAdiTxt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCol;
        private DevExpress.XtraGrid.Columns.GridColumn AdCol;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraGrid.GridControl yazarGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn IdColYazar;
        private DevExpress.XtraGrid.Columns.GridColumn AdColYazar;
        private DevExpress.XtraGrid.Columns.GridColumn SoyadColYazar;
        private DevExpress.XtraGrid.Columns.GridColumn DetayColYazar;
        private DevExpress.XtraEditors.SimpleButton yazarEkleBtn;
        private DevExpress.XtraEditors.SimpleButton yazarSilBtn;
        private DevExpress.XtraEditors.SimpleButton yazarGuncelleBtn;
        private System.Windows.Forms.RichTextBox yazarDetayTxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit yazarSoyadTxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit yazarAdTxt;
        private DevExpress.XtraEditors.SimpleButton ekleBtnKitap;
        private DevExpress.XtraEditors.SimpleButton silBtnKitap;
        private DevExpress.XtraEditors.SimpleButton guncelleBtnKitap;
        private DevExpress.XtraEditors.TextEdit fotografLinkiTxtKitap;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LookUpEdit yazarLookUpKitap;
        private DevExpress.XtraEditors.LookUpEdit kategoriLookUpKitap;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit sayfaSayisiTxtKitap;
        private DevExpress.XtraEditors.TextEdit yayinEviTxtKitap;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit basimYiliTxtKitap;
        private DevExpress.XtraEditors.TextEdit kitapAdiTxtKitap;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraGrid.GridControl kitapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn IdColKitap;
        private DevExpress.XtraGrid.Columns.GridColumn AdColKitap;
        private DevExpress.XtraGrid.Columns.GridColumn BasimYiliColKitap;
        private DevExpress.XtraGrid.Columns.GridColumn YayinEviColKitap;
        private DevExpress.XtraGrid.Columns.GridColumn SayfaSayisiColKitap;
        private DevExpress.XtraGrid.Columns.GridColumn DurumColKitap;
        private DevExpress.XtraGrid.Columns.GridColumn kategoriColKitap;
        private DevExpress.XtraGrid.Columns.GridColumn yazarColKitap;
        private DevExpress.XtraGrid.Columns.GridColumn kitapFotoUrlColKitap;
        private System.Windows.Forms.GroupBox groupBox7;
        private DevExpress.XtraGrid.GridControl hareketGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn IdColHareket;
        private DevExpress.XtraGrid.Columns.GridColumn AlisTarihiColHareket;
        private DevExpress.XtraGrid.Columns.GridColumn IadeTarihiColHareket;
        private DevExpress.XtraGrid.Columns.GridColumn KitapColHareket;
        private DevExpress.XtraGrid.Columns.GridColumn UyeColHareket;
        private DevExpress.XtraGrid.Columns.GridColumn PersonelColHareket;
        private DevExpress.XtraEditors.SimpleButton ekleBtnHareket;
        private DevExpress.XtraEditors.SimpleButton silBtnHareket;
        private DevExpress.XtraEditors.SimpleButton guncelleBtnHareket;
        private DevExpress.XtraEditors.LookUpEdit personelLookUpHareket;
        private DevExpress.XtraEditors.LookUpEdit uyeLookUpHareket;
        private DevExpress.XtraEditors.LookUpEdit kitapLookUpHareket;
        private System.Windows.Forms.DateTimePicker iadeTarihiDtHareket;
        private System.Windows.Forms.DateTimePicker alisTarihiDtHareket;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl gunFarkiLblHareket;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl cezaDurumuLblHareket;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private DevExpress.XtraGrid.GridControl cezaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn IdColCeza;
        private DevExpress.XtraGrid.Columns.GridColumn BaslangicTarihiColCeza;
        private DevExpress.XtraGrid.Columns.GridColumn BitisTarihiColCeza;
        private DevExpress.XtraGrid.Columns.GridColumn paraColCeza;
        private DevExpress.XtraGrid.Columns.GridColumn uyeColCeza;
        private DevExpress.XtraGrid.Columns.GridColumn hareketColCeza;
        private DevExpress.XtraEditors.SimpleButton ekleBtnCeza;
        private DevExpress.XtraEditors.SimpleButton silBtnCeza;
        private DevExpress.XtraEditors.SimpleButton guncelleBtnCeza;
        private DevExpress.XtraEditors.LookUpEdit hareketLookUpCeza;
        private DevExpress.XtraEditors.LookUpEdit uyeLookUpCeza;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.TextEdit paraTxtCeza;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker bitisTarihiDtCeza;
        private System.Windows.Forms.DateTimePicker baslangicTarihiDtCeza;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private System.Windows.Forms.RichTextBox adresTxtUye;
        private DevExpress.XtraEditors.SimpleButton ekleBtnUye;
        private DevExpress.XtraEditors.SimpleButton silBtnUye;
        private DevExpress.XtraEditors.SimpleButton guncelleBtnUye;
        private DevExpress.XtraEditors.TextEdit tcknTxtUye;
        private DevExpress.XtraEditors.TextEdit okulTxtUye;
        private DevExpress.XtraEditors.TextEdit fotografTxtUye;
        private DevExpress.XtraEditors.TextEdit telefonTxtUye;
        private DevExpress.XtraEditors.TextEdit sifreTxtUye;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.TextEdit kullaniciAdiTxtUye;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.TextEdit mailTxtUye;
        private DevExpress.XtraEditors.TextEdit soyadTxtUye;
        private DevExpress.XtraEditors.TextEdit adTxtUye;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private System.Windows.Forms.GroupBox groupBox10;
        private DevExpress.XtraGrid.GridControl uyeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn IdColUye;
        private DevExpress.XtraGrid.Columns.GridColumn AdColUye;
        private DevExpress.XtraGrid.Columns.GridColumn SoyadColUye;
        private DevExpress.XtraGrid.Columns.GridColumn mailColUye;
        private DevExpress.XtraGrid.Columns.GridColumn kullaniciAdiColUye;
        private DevExpress.XtraGrid.Columns.GridColumn sifreColUye;
        private DevExpress.XtraGrid.Columns.GridColumn fotografColUye;
        private DevExpress.XtraGrid.Columns.GridColumn telefonColUye;
        private DevExpress.XtraGrid.Columns.GridColumn adresColUye;
        private DevExpress.XtraGrid.Columns.GridColumn okulColUye;
        private DevExpress.XtraGrid.Columns.GridColumn TcknColUye;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.SimpleButton ekleBtnPersonel;
        private DevExpress.XtraEditors.SimpleButton silBtnPersonel;
        private DevExpress.XtraEditors.SimpleButton guncelleBtnPersonel;
        private System.Windows.Forms.RichTextBox adresTxtPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl40;
        private DevExpress.XtraEditors.TextEdit sifreTxtPersonel;
        private DevExpress.XtraEditors.TextEdit kullaniciAdiTxtPersonel;
        private DevExpress.XtraEditors.TextEdit telefonTxtPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.TextEdit tcknTxtPersonel;
        private DevExpress.XtraEditors.TextEdit soyadTxtPersonel;
        private DevExpress.XtraEditors.TextEdit adTxtPersonel;
        private DevExpress.XtraGrid.GridControl personelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn IdColPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn AdColPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn SoyadColPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn TcknColPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn TelefonColPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn AdresColPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn KullaniciAdiColPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn sifreColPersonel;
        private System.Windows.Forms.GroupBox groupBox14;
        private DevExpress.XtraEditors.SimpleButton ekleBtnDuyuru;
        private DevExpress.XtraEditors.SimpleButton silBtnDuyuru;
        private DevExpress.XtraEditors.SimpleButton guncelleBtnDuyuru;
        private System.Windows.Forms.RichTextBox aciklamaTxtDuyuru;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private System.Windows.Forms.GroupBox groupBox13;
        private DevExpress.XtraGrid.GridControl duyuruGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn IdColDuyuru;
        private DevExpress.XtraGrid.Columns.GridColumn AciklamaColDuyuru;
        private System.Windows.Forms.ComboBox ayCbxKasa;
        private DevExpress.XtraEditors.SimpleButton ekleBtnKasa;
        private DevExpress.XtraEditors.SimpleButton silBtnKasa;
        private DevExpress.XtraEditors.SimpleButton guncelleBtnKasa;
        private DevExpress.XtraEditors.TextEdit yilTxtKasa;
        private DevExpress.XtraEditors.TextEdit tutarTxtKasa;
        private DevExpress.XtraEditors.LabelControl labelControl44;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private System.Windows.Forms.GroupBox groupBox15;
        private DevExpress.XtraGrid.GridControl kasaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn IdColKasa;
        private DevExpress.XtraGrid.Columns.GridColumn AyColKasa;
        private DevExpress.XtraGrid.Columns.GridColumn YilColKasa;
        private DevExpress.XtraGrid.Columns.GridColumn TutarColKasa;
    }
}

