using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmTanitimUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void akiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ooKBenGK3R4");
            label1.Text = "Akira";
            richTextBox1.Text=("Sene 2019... Dünya savaşı esnasında esrarengiz bir silah Tokyo'yu yerle bir etmiştir ve bunun üzerinden tam 30 sene geçmiştir. Tokyo'nun yerine inşa edilen Neo-Tokyo, teknoloji çağının tüm gerekliliklerini yerine getirmektedir. Mafya ve terör ise bu şehrin damarlarına sızmıştır. Artık şehre hükmeden bu devasa kaosu engellemenin, ya da onun hızını kesmenin, hiçbir yolu yoktur. İki eski dost olan Tetsuo ve Keneda, çeteleriyle birlikte gizli bir askeri üsse girmeyi başarır. Ancak biri yakalanır ve deneylerde denek olarak kullanılmaya başlanır. Bunun üzerine kazandığı güçleri, kendi istekleri doğrusunda kullanacaktır.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKuY33CJqqMiG1wW3AG2TtVzUu_TyhG9Qs-Q&usqp=CAU";
        
        }

        private void hadashiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=KjLYP_X80GA");
            label1.Text = "Hadashi No Gen";
            richTextBox1.Text = ("Japonlar, İkinci Dünya Savaşının sonlarına doğru yaklaşırlarken Gen ve ailesi, Hiroşima’da yaşamaktadırlar. Gen’in babası, artık savaşın kazanılma ihtimalinin olmadığı kanısına ulaşmıştır. Bu nedenle kasaba memurlarının öfkesini toplar ve sırayla tüm komşularından ayrı düşer. Bölgedeki ticaret adamlarından sakınmak sureti ile yiyecek kavramı, Gen ve ailesi için kıtlık noktasına doğru ilerler. Tüm bu şeyler de çok geçmeden anlamını yitirir çünkü Amerikan askerleri, ellerindeki korkunç silahı serbest bırakarak Japonlar üzerindeki son saldırılarına başlarlar.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://cdn.myanimelist.net/images/anime/12/10128.jpg";
        }

        private void göktekiKaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=8ykEy-yPBFc");
            label1.Text = "Gökteki Kale";
            richTextBox1.Text = ("Günümüzden uzak bir gelecekte geçen filmde insanoğlu gökyüzünde uçan şehirler inşa etmiş, burada yaşamaya başlamıştır. Bu şehirler büyük bir felaket sonrasında yerle bir olduğunda hayatta kalan insanlar yaşamlarını devam ettirebilmek için yeryüzüne inmek zorunda kalmıştır. Gökyüzünde kalan son kişi ise Laputa'dır. Hikaye Sheeta isimli bir kızı taşıyan bir uçakla açılır. Gökyüzündeki yaşamından yeryüzüne dönmek zorunda kalan Sheeta burada boynundaki büyülü taşın da sayesinde beklemediği tehlike ve aksiyon dolu maceralara atılacaktır.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://unutulmazfilmler.pw/wp-content/uploads/2016/04/Castle-in-the-Sky-630x910.jpg";
        }

        private void kırmızıKanatlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=awEC-aLDzjs");
            label1.Text = "Kırmızı Kanatlar";
            richTextBox1.Text = ("Birinci Dünya Savaşı’nda İtalyan Hava Kuvvetlerinde görev yapmakta olan Porco Rosso (Kurenai no buta) bir hava çatışmasında bilinmeyen bir nedenle domuza dönüşür.Birliğine dönmez ve hava kuvvetlerinde yaptığı işi bırakır. Hava korsanlarını avlayıp karşılığında da ödül almaya başlayan Porco yeni işini bulmuştur ve halinden memnundur.Fakat Amerikalı bir hava korsanı olan Curtis ona meydan okuyup uçağını düşürünce işler kızışır.Ayrıca bir yandan da İtalya’da olduğu bilgisini alan, faşist rejim yanlısı olmuş eski bir arkadaşının tehdidi ile karşı karşıyadır. Ya orduya geri dönecek ya da öldürülecektir.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/bzp/05/10257.jpg";
        }

        private void howlunYürüyenŞatosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=fpFPJ9LyntY");
            label1.Text = "Howl'un Yürüyen Şatosu";
            richTextBox1.Text = ("Howl’un Yürüyen Şatosu harika çizimleri izleyicileri adeta ekrana kilitliyor. Film, kara büyü ile 90 yaşında bir kadına dönüşmüş olan Sophie adındaki bir genç kızı konu alıyor. Sophie, hayattan umudunu kesince hareket eden bir şatoda yaşayan gizemli bir büyücünün yanına gidiyor ve onunla yaşamaya başlıyor. Şatoda yaşayan cinlerden birinin de kendisi ile aynı büyüye maruz kaldığını anladığında, ikili kaderlerini değiştirmek için birlikte çalışmaya başlıyorlar. Ancak tam bu sırada patlak veren savaş, büyüyü bozmak için çalışmalarını artırmalarına yol açıyor.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://i.hizliresim.com/PSCYqM.jpg";
        }

        private void küçükCadıKikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=4bG17OYs-GA");
            label1.Text = "Küçük Cadı Kiki";
            richTextBox1.Text = ("Aile ile izlenebilecek anime filmleri arasında yer alan Küçük Cadı Kiki, cadılık sınavını geçmeye çalışan Kiki’nin hikayesine odaklanıyor. Cadılık güçlerini annesinden devralabilmek için Kiki’nin kendi seçtiği bir şehirde bir yıl boyunca tek başına yaşaması ve bu sırada da önemli bir görevi yerine getirmesi gerekmektedir.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/bzp/01/40137.jpg";
        }

        private void wolfChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ed1xwAtF728");
            label1.Text = "Wolf Children";
            richTextBox1.Text = ("Türkçeye Kurt Çocuklar olarak çevrilen Okami Kodomo No Ame To Yuki, anime film önerileri listemizin belki de en sıcak, en içten yapımlarından biri. Filmde, büyük bir aşkla vurulduğu bir kurt adamdan iki çocuğu olan Hana’nın hikayesi anlatılıyor. Hana’nın kurt adam olan eşi beklenmedik bir şekilde ölünce, tıpkı babaları gibi insan ve kurt karması olan iki çocuğu ile baş başa kalan Hana, çocuklarını herkesten uzakta büyütmeye karar veriyor. Ancak çocuklar büyüdükçe kendilerine dair ikilemleri ve soruları da artıyor. Hana ise tüm bunlarla yalnız bir şekilde baş etmek zorunda kalıyor.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://images-na.ssl-images-amazon.com/images/I/81ruB5vt1IL.jpg";
        }

        private void sakasamaNoPatemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vbBctWCoBf0");
            label1.Text = "Sakasama no Patema";
            richTextBox1.Text = ("Bir dünya hayal edin, uçsuz bucaksız bir karanlık ve olabildiğince uzanan tüneller! Bir de bu dünyanın tam tersi aydınlık bir gökyüzü ve ayaklarının altında uzanan yeşil çimenler… Dünyaları ne kadar karanlık olursa olsun, mütevazı ve hoş görülü insanları koydukları kurallar içerisinde hayatlarını sürdürmeye çalışmaktadır. Ancak koyulan bu kurallara pek inanmayan ve yasak bölgeleri araştırmayı seven Patema büyük bir gerçeği keşfeder. Kimin yer altında kimin yeryüzünde olduğu kavramı artık önemi yitirmiştir! Artık rollerin değişme zamanı gelmiştir.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://i.pinimg.com/originals/d4/6b/f6/d46bf636196d8d96db89467e0bea7e37.jpg";
        }

        private void rüzgarYükseliyorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=EBqGtlDEECU");
            label1.Text = "Rüzgar Yükseliyor";
            richTextBox1.Text = ("Film, 1930’lu yıllarda geçiyor. Ne olursa olsun hayallerinin peşinden koşan Jiro’nun hikayesi anlatılıyor. Doğuştan bazı görme sorunları olan Jiro, her zaman bir uçak tasarımcısı olmayı istemiştir. Bu konudaki ünlü üstat Caproni’yi kendine idol olarak belirleyen Jiro, görme sorunlarına rağmen uçaklarla beraber çalışmanın bir yolunu bulur. Çalıştığı yerde yüksek bir konumda değildir ancak azmi ve yeteneği ile üstlerinin ilgisini çeker. Sonunda ona istediği tasarımı yapma izni verilir. Ancak yaklaşan İkinci Dünya Savaşı her şeyi değiştirirken, Jiro’nun pek fazla vakti yoktur. Üstelik henüz savaşın ona getireceklerinden de habersizdir.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/14/02/28/17/16/513725.jpg";
        }

        private void komşumTotoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=92a7Hj0ijLs");
            label1.Text = "Komşum Totoro";
            richTextBox1.Text = ("Komşum Totoro'da anneleri, isimlendirmeyen ve uzun süreli bir hastalığa yakalandığında ona daha yakın olmak için yattığı hastanenin yakınındaki eski bir eve taşınmak isteyen iki küçük kız, bir profesör olan babalarını da ikna edip bu kırsal yere taşınırlar. Küçük kızlar Satsuki ve Mei zamanla evin içerisinde onlarla birlikte yaşamakta olan, bazı varlıkların olduğunu fark ederler. Bu varlıklardan bir şekilde kurtulduklarında, evlerinin karşısındaki ormanda karşılaştıkları büyüleyici varlıklar iki kardeşi büyülü bir dünyanın içerisine sürüklerler.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/01/14790.jpg";
        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7BG-BpvkYB8");
            label1.Text = "Esaretin Bedeli";
            richTextBox1.Text = ("Esaretin Bedeli, Andy ve Red isimli iki mahkumun parmaklıklar ardında kurdukları dünyanın hikayesini anlatıyor. Andy Dufresne, genç ve başarılı bir bankerdir. Karısını ve karısının sevgilisini öldürmek suçundan yargılanır ve ömür boyu hapis cezası alır. Shawsank Hapishanesi'nde dayak, işkence, tecavüz, her türlü durum yaşanmaktadır fakat Andy gene de hayata bağlı ve iyimserdir. Bu tutumu etrafındakileri de etkiler. Andy umutlu bakış açısıyla çevresindeki tüm mahkumları, parmaklıklar arkasında bile özgür bir yaşam olabileceğine inandırır. Andy'nin bu çabalarına ortak olacak bir arkadaşı da olacaktır.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://i.pinimg.com/236x/af/8b/c1/af8bc1188d632da403c5a451807d7b4a.jpg";
        }

        private void hayatGüzeldirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Cq2IQvTjH0g");
            label1.Text = "Hayat Güzeldir";
            richTextBox1.Text = ("Hayat Güzeldir'de, başkahramanımız hayat dolu Guido’nun güzeller güzeli öğretmen Dora’ya vurulur ve tüm engellere rağmen evlenirler. Ardından bir de çocuk sahibi olan çiftin hayatlarındaki tüm pürüzler ortadan kalktığında savaş patlak verir. Yahudi oldukları için toplama kampına götürüldüklerinde Guido, oğluna esir kampının ve savaşın bir oyun olarak söyleyecek; oğlu, oyunu başarıyla tamamlarsa ödül olarak çok istediği bir oyuncak tankı hediye edecektir.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://hedefepsikoloji.com/wp-content/uploads/2019/07/hedefepsikoloji-film-onerisi-hayat-guzeldir.png";
        }

        private void babamVeOğlumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=qpBxV_nchf0");
            label1.Text = "Babam ve Oğlum";
            richTextBox1.Text = ("Babam ve Oğlum'da, 12 Eylül darbesinin yıktığı hayatlardan birinde yetişmektedir küçük Deniz. Annesini henüz doğmadan önce kaybetmiş, bir gazetede yazar olarak çalışan babası tarafından mütevazi bir evde yetiştirilmiştir. Babası dışında tanıdığı tek bir akrabası bile yoktur. Taki babası Sadık, bir gün Deniz'i şaşırtacak bir haberle gelene kadar.Deniz artık babasıyla birlikte, hiç görmediği dedesinin yanında, küçük bir kasabada yaşayacaktır.Köye vardıklarında Sadık yıllar önce küstüğü babasını ilk kez görüyordur. Aralarındaki bu üskünlük kolay kolay geçecek cinsten bir durum değildir. Sadık'ın dönüş sebebini anlamlandıramayan aile bir yandan çok mutluyken diğer yandan tedirgindir de. Zamanla Deniz bu hiç görmediği ailesine alışırken ve her şey düzelmeye başlamışken yaşanan bir dram herkesi derinden etkileyecektir.");
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRr5n_MD3Gd-o9ldVnP58q9f7c8In4Yl2QiFg&usqp=CAU";
        }

        private void birEvlilikHikayesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=L215PMtgCrs");
            label1.Text = "Bir Evlilik Hikayesi";
            richTextBox1.Text = "Marriage Story, evli bir çiftin New York'tan Los Angeles'a kadar uzanan boşanma hikayesini konu ediyor. Bir yönetmen olan Charlie ve oyuncu olan eşi Nicole, evliliklerinde sona gelen bir çiftir. Boşanmaya karar veren çift, bu süreci kolayca sona erdirmeyi düşünse de işler pek de düşündükleri gibi gitmez. Çocuklarının velayeti işin içine girince, süreç beklediklerinden daha karmaşık bir hal alır. Çiftin bu sırada hayalarına farklı şehirlerde yön vermeye çalışması, işlerin iyice kızışmasına neden olur. Carlie projelerini sürdürmek için New York'ta kalmak isterken, Nicole ise kadrosuna katıldığı televizyon dizisi için Los Angeles'ta yaşamayı planlar. Uzun zaman boyunca içlerinde gömülü kalmış kızgınlıklar da bu giderek agresifleşen boşanma sürecinde ortaya çıkmaya başlar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/19/10/22/09/55/5933030.jpg";
        }

        private void gizemliNehirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=b0Nq6yVHbCo");
            label1.Text = "Gizemli Nehir";
            richTextBox1.Text = "Jimmy, Sean ve Dave isimli üç küçük çocuk caddede hokey oynadıkları sırada polis görünümündeki kişiler tarafından oyunu bırakmaları için uyarılırlar. Bu sert görünümlü adamlar Dave'i arabalarına alıp küçük çocuğa günlerce cinsel tacizde bulunurlar.Bu olayın üzerinden 25 yıl geçmiştir. Küçük çocuklar artık büyümüş, bu süreçte de görüşmemiştirler.Jimmy'nin esrarengiz bir şekilde hayatını kaybeden kızı, eski dostları tekrardan bir araya getirir. Artık bir polis olan Sean cinayetin ardında yatan gizemleri çözerek çocukluk arkadaşına yardım etmeye karar verir. Ancak bu cinayetteki esrar perdesi, arkadaşlıklarının ilk yıllarına kadar uzanan bir dizi gizemi doğuracaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/01/34680.jpg";
        }

        private void çizgiliPijamalıÇocukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=5zuRB359sk4");
            label1.Text = "Çizgili Pijamalı Çocuk";
            richTextBox1.Text = "2. Dünya Savaşı’nın kara günlerinde, arkadaş olmaya çalışan iki çocuğun hikayesi. 8 yaşındaki Bruno ailesiyle Berlin'den ayrılır ve Polonya'da yaşamaya başlar. Babasının işi için taşındıkları bu yerde bir de arkadaş edinir. Arkadaşı tellerin arkasında kalan bir Yahudi'dir.Bruno'nun yaşadığı yer, 1.5 milyon Yahudi'nin öldürüldüğü Auschwitz toplama ve yoketme kampının bitişiğindedir. Oğlunun tellerin ardında yaşananlarla ilgili gerçeği öğreniceğinden kaygılanan Bruno'nun annesiyse oğlunu bu ’’arkadaş’’lıktan korumaya çalışır.John Boyne’un dünya çapında güzel eleştiriler alan aynı adlı romanından uyarlanan film, tarihin acıyla dolu anısını küçük bir çocuğun gözünden hatırlatarak, masumiyet ve insanlık dehşetini zarif bir dille beyazperdeye yansıtıyor.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://www.filmonerileri.org/wp-content/uploads/2019/08/cizgili-pijamali-cocuk-the-boy-in-the-striped-pyjamas-2008.jpg";
        }

        private void bizimİçinŞampiyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=3s87gCHsm6c");
            label1.Text = "Bizim İçin Şampiyon";
            richTextBox1.Text = "Gerçek bir hikayeden uyarlanan filmde, Türk atçılığının önemli ismi Özdemir Atman’ın sahibi olduğu Bold Pilot, at yarışı ile ilgilenmeyenlerin bile sevgisini kazanan bir attır. Bold Pilot ve onun daimi jokeyi Halis Karataş, birlikte unutulmaz başarılara imza attılar. İkilinin 1996 yılı Gazi Koşusu’ndaki 2:26:22’lik rekoru hala geçilemedi. Bold Pilot'ın diğer bir başarısı da, Halis Karataş ve Begüm Atman’ın bir araya gelmesine vesile olması. Ünlü jokey ve Begüm Atman arasındaki destansı aşkın konu edildiği filmin yönetmen koltuğunda, Ahmet Katıksız oturuyor. Senaryosunu Katıksız ile Serkan Yörük’ün kaleme aldığı filmde ünlü jokey Halis Karataş’a Ekin Koç, Begüm Atman’a ise Farah Zeynep Abdullah hayat veriyor. Türkiye Jokey Kulübü eski başkanlarından Özdemir Atman’ı ise usta oyuncu Fikret Kuşkan canlandırıyor.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/5/56/Bizim_I%C3%A7in_Sampiyon.jpg";
        }

        private void umudunuKaybetmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Ha4EmazlcXM");
            label1.Text = "Umudunu Kaybetme";
            richTextBox1.Text = "İyi bir baba olan Chris Gardner, işinde sorunlar yaşayan, maddi açıdan sarsıntıda olan ve aynı zamanda iyi bir eş olan bir adamdır. Ancak ne yazık ki eşi sıkıntılara daha fazla katlanamayacağına karar vererek onu terk eder. Christopher adındaki oğulları da babasının yanında kalır. Karısının terk edişi de yetmezmiş gibi bir de ev sahibi dışarı atar baba –oğulu. Sokaklarda kalıp, tuvaletlerde, düşkünler evinde çalışarak ayakta durmaya çalışır. Oğlunun sevgisi bu mücadeleci baba için her şeydir. Ve sevgiye eklenen bir var olma savaşı hiç şüphesiz, vakti geldiğinde en mükemmel kapıları açacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/bzp/01/54098.jpg";
        }

        private void lionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=0BKY6yKC9sw");
            label1.Text = "Lion";
            richTextBox1.Text = "5 yaşındaki Hintli bir çocuk ağabeyinin geri dönmesini beklerken bir tren vagonunda uyuyakalır. O uyurken trenin yola çıkması sonucu küçük çocuk uyandığında kendini evinden kilometrelerce uzakta bulur. Artık kayıptır ve eve nasıl döneceğine dair bir fikri yoktur. Kendini Calcutta'da bulan küçük çocuk büyük mücadelelerden sonra Avustralyalı bir çift tarafından evlat edinilir ve sevgiyle büyür. Ancak ailesini bulma isteği giderek bir saplantıya dönüşür. Elinde hiçbir şey olmadan ilerlemeye çalışan genç adamın içindeki çaresizlik zamanla hayatını da etkilemeye başlar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://im.haberturk.com/2019/10/29/ver1572348903/2535397_414x414.jpg";
        }

        private void piyanistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=jV_LxL_n4no");
            label1.Text = "Piyanist";
            richTextBox1.Text = "Piyanist, İkinci Dünya Savaşı sırasında yaşanan gerçek bir dramı konu alır. Polonya’lı ünlü piyanist Wladyslaw Szpilman’ın anılarını anlattığı aynı isimli kitaptan sinemaya uyarlanan film, Nazi işgali altındaki Polonya’da yaşamanın imkansızlaştırıldığı bir dönemde, bir şekilde esir kampına gitmekten kurtulan ünlü piyanistin Varşova’nın kenar mahallelerindeki hayatta kalma mücadelesine odaklanır. Varoşlarda tam anlamıyla sefil bir hayat süren müzisyen, diğer halkla birlikte, kıtlığa ve aşağılanmalara maruz kalsa da kahramanca mücadele edecektir. Günü gelip oradan kaçma şansı bulduğundaysa başkentin harabelerine sığınacak, beklemediği bir anda gelen bir yardımla umudunu yeniden kazanacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/03/28359.jpg";
        }

        private void başlangıçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=YoHD9XEInc0");
            label1.Text = "Başlangıç";
            richTextBox1.Text = "Leonardo DiCaprio bu yapımda, çok yetenekli bir hırsız olan Dom Cobb  ile karşımızda. Uzmanlık alanı, zihnin en karanlık ve savunmasız olduğu rüya görme anında, bilinçaltının derinliklerindeki değerli sırları çekip çıkarmak ve onları çalmaktır. Cobb'un bu nadir insanlarda görülebilecek yeteneği, bu ender rastgelinebilecek mahareti, onu kurumsal casusluğun tehlikeli yeni dünyasında aranan bir oyuncu yapmıştır. Aynı zamanda bu durum onu uluslararası bir kaçak yapmış ve sevdiği herşeye malolmuştur. Cobb'a içinde bulunduğu durumdan kurtulmasını sağlayacak bir fırsat sunulur. Ona hayatını geri verebilecek son bir iş; tabi eğer imkansız 'başlangıç'ı tamamlayabilirse. Mükemmel soygun yerine, Cobb ve takımındaki profesyoneller bu sefer tam tersini yapmak zorundadır; görevleri bir fikri çalmak değil onu yerleştirmektir. Eğer başarırlarsa, mükemmel suç bu olacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/01/143692.jpg";
        }

        private void olağanŞüphelilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=oiXdPolca5w");
            label1.Text = "Olağan Şüpheliler";
            richTextBox1.Text = "Olağan Şüpheliler'de, San Pedro’da patlayan bir tekneyi araştıran polis, teknede 27 ceset ve 91 milyon dolarlık uyuşturucu parası bulur. Olaydan kurtulan iki kişiden biri yanıklarla dolu vücuduyla korkmuş bir Macar terörist ve diğeri de Verbal Kint adında bir tetikçidir. Polisteki sorgusunda Kint, 6 hafta öncesinden başlayarak tüm olayları anlatır. Beş suçlunun nasıl bir araya geldiğinden, kaçırılan bir kamyondan ve bir suç lordundan polislere bahseder.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/01/12837.jpg";
        }

        private void prestijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=bBFFhMVk0FU");
            label1.Text = "Prestij";
            richTextBox1.Text = "Prestij, birbirini alt etmeye çalışan iki sihirbazın hikayesini anlatıyor. 19.yy sonlarında Londra’da Robert Angier, sevgili eşi Julia McCullough ve Alfred Borden hem arkadaştırlar hem de bir sihirbazın asistanlarıdırlar. Bir gösteri esnasında Julia ölünce Robert, onun ölümünden Alfred’i suçlar ve birbirlerine düşman olurlar. Zaman içinde ikisi de hem ünlü olurlar hem de rakip sihirbazlara dönüşerek birbirlerinin sahne üstünde performansını sabote etmeye kalkışırlar. Alfred başarılı bir hile yapınca Robert, rakibinin sırrını çözmek konusunu takıntı halinde getirir ve trajik olaylar birbirini kovalar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/bzp/01/108998.jpg";
        }

        private void köstebekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vGHzLcqacPo");
            label1.Text = "Köstebek";
            richTextBox1.Text = "Birimin başındaki isim olan Control'ün sağ koluyken, görevden uzaklaştırılan İngiliz casusu George Smiley (Gary Oldman), hükumet tarafından gizlice tekrar kiralanır. Zira, İngiliz Gizli İstihbarat Servisi Sirk'in içinde Sovyetler Birliği için çalışan 'köstebek' bir ajan olduğu şüphesi tüm örgütü sarmıştır.Smiley şimdi gözden çıkartılan kafatası avcılarını himayesine alma pahasına Budapşte'den İstanbul'a uzanan bir ihanet hikayesini çözerek itibarını geri kazanmaya çalışacaktır...Klasikler arasına girmiş aynı adlı romanın uyarlaması ve televizyon için çekilen dizinin yeniden çevrimi olan yapım 1950'li yıllarda yaşanan soğuk savaş döneminin en keskin günlerine odaklanıyor.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/bzp/01/55983.jpg";
        }

        private void ihtiyarDelikanlıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=C5fhnxF93OQ");
            label1.Text = "İhtiyar Delikanlı";
            richTextBox1.Text = "İhtiyar Delikanlı, yıllarca hapis tutulan bir adamın serbest bırakılmasının ardından intikam arayışını konu ediyor. Oh Dae-Soo adında bir adam, bir gün kaçırılır ve 15 yıl boyunca eski püskü bir hücrede tutuklu kalır. Hiçbir açıklama yapılmamıştır. Sonra bir gün serbest bırakılır. Eline, para, cep telefonu ve pahalı kıyafetler verilir. Bu adam başına gelen bu durumun nasıl ve neden olduğunu anlamak ve gereken intikamı almak konusunda kararlıdır. Bu sırada Oh Dear-Soo aslında kendisini kaçıranların daha da büyük bir planının olduğunu keşfeder. Ancak bu planın özü acı dolu bir yoldan geçmektedir. Gerçeği bulmak ise bu yolun ta kendisidir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/bzp/03/54137.jpg";
        }

        private void spotlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=pDZ9quCjxAM");
            label1.Text = "Spotlight";
            richTextBox1.Text = "Spotlight, taciz olayıyla gündeme gelen bir kilisenin kendini aklamaya çalışmasını ve bu tacizi aydınlatmaya çalışan Boston Globe gazetesi yazarlarını konu alıyor. Gazetenin yazarlarından oluşan “Spotlight” takımı, Katolik Kilisesi’ndeki taciz iddilarıyla ilgili eski defterleri deşer. Bir senelik araştırmaları sonucunda, Boston’ın üst düzey dini, yasal ve idari birliğine ait on yıllarca gizlenen gerçeklere parmak basılır. Yeni atanan genel yayın yönetmeni Marty Baron 2001 yazında Globe’un başına geçmek üzere Miami’den geldiğinde, ayağının tozuyla Spotlight ekibini, 30 yıl boyunca düzinelerce çocuğa cinsel istismarda bulunmakla suçlanan yerel bir rahip hakkındaki bir makaleyi takip etmekle görevlendirir. Boston’da Katolik Kilisesi’ni hedef almanın çok büyük yankı uyandıracağını bilen Spotlight editörü Walter “Robby” Robinson, muhabirler Sacha Pfeiffer (Rachel McAdams) ve Michael Rezendes ve araştırmacı Matt Carroll davaya daha derinlemesine dalmaya karar verirler";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://images-na.ssl-images-amazon.com/images/I/91F8ampdMOL._SY606_.jpg";

        }

        private void tutsakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ipqARUF38n0");
            label1.Text = "Tutsak";
            richTextBox1.Text = "Tutsak, adaleti kendi elleriyle sağlamaya çalışan bir adamın hikayesini anlatıyor. Maccachusetts eyaletinin Brockton bölgesinde, Şükran Günü'nü kutlamak için bir araya gelen Dovers ve Birches aileleri her şeyin yolunda gittiği bu yemek esnasında korkunç bir haberle altüst olurlar. Gecenin ilerleyen saatlerinde ailelerin iki küçük kızlarının kaybolması sonrasında panik dolu anlar yaşanır. Saatler ilerler, ancak kızlar halen daha ortada yoktur ve durum kaçırılmış oldukları gerçeğini kuvvetlendirir. Polise başvursalar da hızlı ve nitelikli bir sonuç alamazlar. Keller Dover ise bir hayli panik içerisindedir ve polisin çabalarını yetersiz bulup adaleti kendi elleriyle aramaya karar verir. Genç ve başarılı dedektif Loki'den de yardım isteyen genç adam, kendini suçlu ve masumun birbirine karıştığı oldukça şaibeli bir davanın içerisinde bulur.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://www.hdfilmcehennemi2.pw/wp-content/uploads/2013/12/Tutsak-izle.jpg";
        }

        private void zindanAdasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=AIkiKDuCsaA");
            label1.Text = "Zindan Adası";
            richTextBox1.Text = "Zindan Adası, Martin Scorsese'nin bir çok filmi gibi yine bir başyapıt statüsünde. Filmde, Teddy Daniels ve Chuck Aule isimli iki polis memurunun, Rachel Solando adlı bir akıl hastasının ortadan kaybolması üzerine tehlikeli akıl hastalarının tedavi gördüğü Shutter Adası isimli bölgede konuşlanan Ashecliffe Hastanesi'ne soruşturma yapmak için gitmesi ve sonradan gelişen esrarengiz olaylar aktarılıyor. Burada karşılaştıkları isyan tablosu ve çığrından çıkan işler bu davayı gittikçe zora sokacak, zamanla rüya ve gerçek arasındaki sınırlar zorlanacaktır. Usta yönetmen Martin Scorsese tarafından Dennis Lehane'nin ünlü romanından sinemaya uyarlanan filmin başrolünde yönetmenin gözde oyuncularından Leonardo Di Caprio bulunuyor.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/bzp/01/132039.jpg";
        }

        private void kayıpKızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7iJXGWfcYkA");
            label1.Text = "Kayıp Kız";
            richTextBox1.Text = "Kayıp Kız, karısının aniden ortadan kaybolmasından sorumlu tutulan bir adamın hikayesini anlatıyor. Amerika'nın Missouri eyaletlerinden birinde sıcak bir yaz sabahı, Nick ve Amy evliliklerinin beşinci yıl dönümünü kutlamaya hazırlanmaktadır. Fakat o gün Amy aniden ortadan kaybolur. Amy'den uzun süre haber alınamayınca polis, genç kadının ortadan kaybolması ile ilgili Nick'ten şüphelenmeye başlar. Olanlara bir türlü anlam veremeyen Nick'in ise Amy'nin nerede olduğuna dair hiçbir fikri yoktur. Genç adam bu sırada kendisini Amy'nin ailesinin düzenlediği bir yardım operasyonunun içinde piyon olarak bulur. Nick, masum olduğu konusunda ısrar etse de üstündeki şüpheleri tamamen yok edemez. Amy'nin hayatta olup olmadığı ise büyük bir muammadır";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/14/09/15/15/53/421564.jpg";
        }

        private void görünmeyenMisafirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=nuwW4ZHqq94");
            label1.Text = "Görünmeyen Misafir";
            richTextBox1.Text = "Adrian Doria kariyerinde hızla yükselen bir iş adamıdır. Evli bir adam olan Adrian, fotoğrafçı olan sevgilisi Laura’yı öldürmekle suçlanmaktadır. Adrian, kendisine güvenilir bir savunma yaratmak için tanık hazırlama ve adli bildirimlerde uzman deneyimli bir avukat olan Virginia Goodman ile tanışır. Adrian, Virgina’ya yaşanan olayları en başından anlatmaya başlar. Fakat Virginia hikayede bazı tutarsızlıklar fark eder ve onu hikayesinin karanlık noktalarını açığa çıkarması için zorlar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQzWogbaZfLenLO3g5bLn5z3dMqJx51VGO1A&usqp=CAU";
        }

        private void nefesiniTutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=KFjC_xkqYfQ");
            label1.Text = "Nefesini Tut";
            richTextBox1.Text = "Nefesini Tut kör bir adamın evine girip hırsızlık yaparak yakalanmadan kurtulabileceklerini düşünen bir grup genci temel alıyor. İstismarcı annesinden kurtulup, kız kardeşini her ikisi için de sonu yokmuş gibi görünen bu hayattan kurtarmaya kararlı olan Rocky ve arkadaşları Alex ile Money'nin planları oldukça basittir. Kör bir adamın evinde kilitli tuttuğu odaya girmek, onun engelli oluşundan yararlanarak evini soymak. Ancak işler tam olarak planlandığı gibi gitmez. Zira hafife aldıkları ev sahibi aslında oldukça tehlikeli bir adamdır. Planda yanıldıklarını anladıklarında kusursuz bir suç yerine ölümcül bir hata işlediklerini görürler.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/16/08/15/13/27/451360.jpg";
        }

        private void anabellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=MQpq7gmXpq0");
            label1.Text = "Annabelle";
            richTextBox1.Text = "John Form, oyuncak bebek koleksiyonu yapan hamile eşi Mia için yeni bir oyuncağı gözüne kestirir. Beyaz gelinlik giydirilmiş, eşine zor rastlanır bu antika oyuncak bebek Mia için kusursuz bir hediye olacaktır. Mia beklediği gibi hediyesi Annabelle'i görünce mutlu olur, ancak bu güzel anlar çok uzun sürmez. Form ailesinin evi bir gece evleri sapkın bir tarikat tarafından basılır ve ciddi bir saldırıya uğrarlar. Saldırganlar uzaklaşırlar ancak hiçbir şey çözülmüş değildir. Zira ailenin hiç tahmin edemeyeceği bir kötü ruhu evde bırakmışlardır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://images.moviesanywhere.com/412278051451bd29427d51bcb3fc468e/4311f1f7-9863-4be4-a45b-921adcf4dbac.jpg";
        }

        private void klinikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=eth7JUKVwok");
            label1.Text = "Klinik";
            richTextBox1.Text = "Karanlık geçmişi olan bir psikiyatrist şiddetli bir saldırıya uğrar. Kendi hayatını yoluna koymak için bir kaza sonucu tanınmayacak hale gelen hastasını tedavi etmeye başlar. Ancak korkunç geçmişinden  uzaklaşamaz ve sürekli korkunç saldırıyı hatırlar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/17/01/18/10/14/084440.jpg";
        }

        private void grawlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=H6MLJG0RdDE");
            label1.Text = "Crawl";
            richTextBox1.Text = "Ölümcül Sular, şiddetli bir kasırgaya karşı yaşam savaşı veren genç bir kadının hikayesini konu ediyor. Florida’da 5. Kategorideki bir kasırga ile karşı karşıya kalan genç kadın, bölgedeki diğer sakinler gibi evini terk etme emrini yerine getirmemeye karar verir. Kasırga yaklaşırken botuna atlayıp kayıp olan babasını aramaya çıkar. Bölgeyi sel basmaya başladığında babasını ve köpeğini bulan genç kadın, yaralanmış olan babasını kurtarmaya çalışırken kendisini su altında kalan bir evin içinde bulur. Evin içine hapsolan baba-kız kısa süre sonra korkulması gereken tek şeyin kasırga ve seller olmadığını fark ederler. Azgın suların içinde devasa bir timsah sürüsü dolaşmaktadır. Baba kız, Florida'nın en vahşi ve korkulu avcılarına karşı kendini korumak için savaşmak zorundadırlar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://m.media-amazon.com/images/M/MV5BNTk4MTliYzgtOGI2Ni00N2I5LTg4MjktZTkzZTE0MWVjNGEyXkEyXkFqcGdeQXVyMTA3MTA4Mzgw._V1_.jpg";
        }

        private void paranormalActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=IBEhwiGmOKk");
            label1.Text = "Paranormal Activity";
            richTextBox1.Text = "Paranormal Activity, insanoğlunun bilinçaltındaki en ilkel korkularını gıdıklayarak başarıya ulaşan, zeki film serilerinden. Film, çok düşük bütçelerle, sadece insanın endişe ve hayalet ve bilinmeyen korkusuna dayalı kurgusuyla bir hayli ses getirdi dünya ölçeğinde. Micah ve kız arkadaşı Katie San Diego'nun sessiz, sakin ve ıssız yerleşim yerlerinden birine tanışırlar. Başlarda her şey yolunda gibi görünüyordur. Ancak Katie'nin bir sorunu vardır. Genç kız küçük yaşlarından bu yana uhrevi bir mahluk tarafından takip edildiğini hissetmektedir ve bu varlık bu yeni evde de takiptedir! Olayın ardındaki gizemi çözmeye karar veren Micah, yatak odalarına bir el kamerası düzeneği kurarak bu ecinniyi alt edebileceğini düşünür. Böylece olağandışı bir olay meydana geldiğinde, bir peri, cin ya da hortlak evlerine davetsiz misafirliğe kalkıştığında tüm ayrıntısıyla kayıt altına alabileceklerdir. Başlarda ayak sesleri gibi basit seslerin duyulmasıyla başlayan bu olaylar silsilesi, zamanla şiddetini artırarak genç çifti korku dolu anlara sürükleyecektir. ";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/13/12/11/15/58/373711.jpg";
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hunXjEN-09E");
            label1.Text = "Korku Seansı";
            richTextBox1.Text = "onusunu gerçek bir hikayeden alan Korku Seansı, doğaüstü olayları inceleyip aydınlatmaya çalışan dünyaca ünlü çift Ed ve Lorraine Warren'ın karşılaştıkları ürkütücü bir vakayı ele alır. Ed ve Lorraine Warren bir gün Perron ailesinden bir telefon aldıklarında hayatlarının en korkutucu görevine atıldıklarının farkında değildir. Perron ailesinin gözlerden uzak çiftlik evi nedeni bilinmeyen karanlık bir varlık tarafından kuşatılmıştır ve bu nedenle de hayatları tam bir kabusa dönüşmüştür. Bu vakayı çözebileceklerine inanan deneyimli Warren çifti, ne kadar şeytani bir varlıkla karşı karşıya olduklarını çok geç fark edeceklerdir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/210/263/21026346_20130812140044703.jpg";
        }

        private void cinnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=odvvFZCnjgc");
            label1.Text = "Cinnet";
            richTextBox1.Text = "Cinnet, çok sevdiği kocasının öldüren ancak olaya dair hiçbir şey hatırlamayan genç bir kadının yaşadıklarını konu ediyor. Nida, eşi ve kızı ile mutlu bir hayatı olan genç bir kadındır. Ancak onun huzurlu hayatı, bir gece cinnet geçirmesiyle kabusa dönüşür. Nida, geçirdiği cinnet sonucu çok sevdiği kocasını vahşi bir şekilde öldürür. Ancak o, yaşanan hiçbir şeyi hatırlamamaktadır. Sabah uyandığında kocasının cesedi ile karşı karşıya kalan Nida, yaşananları hatırlamaya çalışsa da bir sonuca varamaz. Bu sırada cinayetin videosu internette yayılmaya başlayınca işler iyice karışık bir hal alır. Kendisini temize çıkarmak isteyen Nida, problemi çözene kadar kaçmaya karar verir. Nida, sorunun zihninin derinliklerinde olduğunu düşününse de gerçekler hiç de öyle değildir. Tüm işaretler, ona musallatt olan korkunç bir cini göstermektedir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/19/05/23/08/38/1189753.jpg";
        }

        private void testereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=4MGReT9-cAg");
            label1.Text = "Bulbbul";
            richTextBox1.Text = "Yıllar sonra evine geri dönen adam, kardeşinin evlendiği çocuk yaşta olan gelinin büyüyüp halkını yöneten gizemli bir kadına dönüştüğünü görür. Kadın, terk edilmiş bu köyü yönetir. Ancak köyde esrarengiz şekilde erkek nüfusu kırıma uğramıştır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/en/thumb/4/46/Bulbbul.jpg/220px-Bulbbul.jpg";
        }

        private void sessizBirYerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=tH-dZY_6-b0");
            label1.Text = "Sessiz Bir Yer";
            richTextBox1.Text = "2 çocuklu bir aile, izole bir kırsalda sakin bir yaşam sürmektedir. Henüz büyüme çağlarında olan çocuklar da, ebeveynleri de hiçbir şekilde konuşmamakta, işaret diliyle anlaşmaktadır. Ancak bunun sebebi konuşamıyor olmaları değildir. Aile gıcırtı çıkaracak her türlü adımdan, ses yapacak her türlü hareketten uzak durmaktadır. Ancak günün birinde bu sakin hayat, küçük çocukların oyun oynarken bir lambayı devirmeleri ile tepetaklak olur. Durgun sessizliğin içinde çıkan bu ses, ailenin peşindeki varlığın dikkatini hemen çekecek ve aile sessizliklerini bozmanın bedelini ağır ödeyecektir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://www.intersinema.com/film/resimler/12/12103_a_2247.jpg";
        }

        private void garezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7BTWkq92ma0");
            label1.Text = "Garez";
            richTextBox1.Text = "Garez, bir ruhun musallat olduğu eve giren insanların başlarına gelen olayları konu ediyor. Bekar bir anne genç bir dedektif ile birlikte mahallesinde bulunan evde yaşanan bir cinayeti araştırmaya başlar. Banliyöde bulunan evin genç annesi, tüm ailesini evin içinde katletmiştir. Olayı incelemekle görevlendirilen bir dedektif ve kadın, araştırmalarını ilerlettikçe evin, içinde yaşayanları ölüme mahkum eden bir hayalet tarafından lanetlendiğini keşfeder. Mahallesindeki laneti öğrenen bekar anne, kendisini ve oğlunu lanetli evdeki şeytani ruhlardan kurtarmak için zorlu bir mücadeleye girişir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/20/02/07/14/44/5323776.jpg";
        }

        private void kungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=L19lDEcEXtg");
            label1.Text = "Kung Fu Panda";
            richTextBox1.Text = "Beş yıldan uzun süren bir çalışma sonucunda ortaya çıkan animasyon harikası Kung Fu Panda'nın üç sloganı var: ''Kendi kahramanın ol!'', ''Panda-mania başlıyor!'' ve ''Çok muhteşem olacak!'' Kung Fu fanatiği panda Po, Huzur Vadisi’ni Kar Leoparı Tai Lung’dan kurtarmak için Kung Fu dünyasına adım atar. Çevresine göre bu iş için biraz fazla kilolu ya da beceriksiz olabilir! Ancak zamanla kendisine inandığı takdirde neler yapabileceğini keşfeder.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://m.media-amazon.com/images/M/MV5BODJkZTZhMWItMDI3Yy00ZWZlLTk4NjQtOTI1ZjU5NjBjZTVjXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_.jpg";
        }

        private void çılgınHırsızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=o8h-twNOzbc");
            label1.Text = "Çılgın Hırsız";
            richTextBox1.Text = "Gru adındaki kafası karışık ve kötü yürekli kişinin en büyük hayali dünyanın uydusu Ay'ı ele geçirmektir. Aslında etrafı barış ve huzurla bezeli, renk renk çiçeklerle çevrili, güleryüzlü komşuluk ilişkilerinin sürdüğü bu varoş semtinde sükuneti bozan tek olgu Gru'nun bu hırslı halidir. Bu banliyöde, bu yaşantıyı bozacak bir sır vardır, bu sır Gru'nun kötü emelleridir. Banliyönün en bakımsız ve çirkin evinde yaşayan Gru, küçük köleleri ile birlikte dünyanın kaderini değiştirecek bu planını uygulamaya sokmak için son hazırlıklarını yapmaktadır. Gru, dünyanın uydusu Ay’ı çalmayı kafaya koymuştur bir kere! Üç küçük yetim olan Margo, Edith ve Agnes, bu habis ruhlu adamla karşılaştıklarında ise, hiç kimsenin göremediği bir ayrıntıyı fark ederler: Gru onlar için potansiyel bir baba adayıdır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/bzp/03/140623.jpg";
        }

        private void şirinlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=85qi71Hk97A");
            label1.Text = "Şirinler";
            richTextBox1.Text = "Şirinler'in yeni macerasında ekip yine bir görev uğruna yollara koyulur. Gizemli bir harita ortaya çıkar ve gizli bir köyün yerini işaret eder. Bunun üzerine bu köyün güvenliği artık Şirinler'in ellerindedir. Şirine, Gözlüklü Şirin, Sakar Şirin ve Güçlü Şirin gizemli ormanda yolculuk ederek bu köyü keşfetmeye karar verirler. Ancak kötü kalpli Gargamel'in de bu haritadan haberi olur ve o da bu gizemli köyün peşine düşer. Artık bu köyü Gargamel'den önce bulmak Şirinler'in en büyük görevi haline gelir. Bu yolda Şirinler tarihinin en büyük gizemini de çözeceklerdir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://i.ytimg.com/vi/aC9u19bqMKE/maxresdefault.jpg";
        }

        private void yürüyenŞatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CwXOrWvPBPk");
            label1.Text = "Shrek";
            richTextBox1.Text = "Shrek, oldukça korkutucu bir görünüme sahip, devasa, yeşil bir troldür. Yalnızlığın getirisiyle, hayatının geri kalanını beraber geçirebileceği, en az kendisi kadar çirkin bir yaratık bulmanın hevesindedir. Bir kahin, kehanetini açıklar. Şrek ile güzeller güzeli bir prenses olan Fiona arasında duygusal bir ilişki cereyan edecektir. Ancak Şrek ne kadar çirkinse Fiona bir o kadar güzeldir. Oldukça garip durumlar ve vaziyetler peyda olmak üzeredir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/03/27415.jpg";
        }

        private void leyleklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Zc9R3abjwA8");
            label1.Text = "Leylekler";
            richTextBox1.Text = "Leylekler'in bebekleri getirdiği devir kapanmış, şimdilerde global bir internet perakende şirketi için paket dağımı yapmaktadırlar. Dev internet mağazası Cornerstore.com’da çalışan ve terfi etmek üzere olan leylek Juinor yanlışlıkla Bebek Yapma Makinesi’ni çalıştırır ve istenmeyen tatlı bir bebek dünyaya gelir. Uzun yıllardır bebek teslimi yapmayan Junior ve Leylek Dağı’ndaki tek insan Tulip’in bu bebeğe ev bulmaları gerekmektedir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/16/08/16/10/51/334633.jpg";
        }

        private void küçükDenizKızıPonyoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CsR3KVgBzSM");
            label1.Text = "Küçük Deniz Kızı Ponyo";
            richTextBox1.Text = "Ponyo, kırmızı elbise giyen ve insan olmak isteyen bir Japon süs balığıdır. Deniz kenarında, iç denize bakan bir kayanın üzerinde yaşayan beş yaşındaki Sosuke, bir sabah, kayalık sahilinde oynarken, saçlarını reçel kavanozuna sıkıştırmış Ponyo ile tanışır. Sosuke onu kurtarıp plâstik bir kovaya koyar.Zaman geçtikte Ponyo ve Sosuke birbirlerine hayran kalırlar. Sosuke, Ponyo’ya korkmamasını ve onu koruyacağını söyler. Ama bir zamanlar insan olan Ponyo’nun babası Fujimoto onu okyanusa dönmesi için zorlar. Ponyo, insan olmak istediğini söyler ve istemeden de olsa dünyanın ekolojik dengesini bozar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/bzp/03/127194.jpg";
        }

        private void süngerBobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=jIYeJ_VTiBI");
            label1.Text = "Sünger Bob";
            richTextBox1.Text = "Bikini Bottom için durum berbat bir haldedir. Biri King Neptün’ün tacı çalmıştır. Suç zanlısı olarak Mr Krab görünmektedir. Ancak böyle bir suçlamayı kabul etmeyen Sponge Bob, bir şeyler yapabilmek için en iyi arkadaşı Patrick ile birlikte yola koyulur. Shell City’e gideceklerdir. Eğer elinden bir şeyler gelir de bu ortadan kaybolan tacı yerine koyabilirlerse, haliyle Mr Krabs’in de hayatını kurtarmış olacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/19/11/15/09/07/4021757.jpg";
        }

        private void muhafızKardeşlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=fZX6BO5eL5g");
            label1.Text = "Muhafız Kardeşler";
            richTextBox1.Text = "İnsanları koruyan, gökyüzünde bulutların üzerinde yaşayan koruyucu ruhlar, artık insanlardan uzak yaşamaktadırlar ve insanlara artık yardım etmeleri yasaktır. Çünkü zaman değişmiş, artık insanlar da onlardan yardım beklememektedirler. Annesiyle yaşayan Rain adlı bir kız çocuğu büyükannesinin ölümünün ardından gökyüzüne yolladığı bir uçurtmayla koruyucuların tekrar harekete geçmesini sağlar. Böylece Rain ve annesi, büyükannenin mirası olan ve geleneksel tariflere sadık kalan çorba dükkanlarını yürütebilmek için iki efsanevi koruyucu kardeşin (Yu Lei ve Shen) desteğini almaya başlarlar. Çünkü fast food restoran sahibi komşuları Rogman, kendi dükkanını genişletebilmek adına dükkanı ele geçirmek için hain planlar yapmaktadır sürekli. ";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://www.cocuklasinema.com/assets/admin/images/movie/i2peThe_Guardian_Brothers.jpg";
        }

        private void süperÖcülerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=w2ZVHOvF1zk");
            label1.Text = "Süper Öcüler";
            richTextBox1.Text = "Dünyanın en ünlü öcülerinin okul öncesi çağındaki çocukları, bir yandan anaokuluna hazırlanırken özel güçlerinde ustalaşmaya çalışır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://i.pinimg.com/474x/6e/9b/46/6e9b46ee81de003bbb0ff49da54aed32.jpg";
        }

        private void kralŞakirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=DdGbXYqhjdY");
            label1.Text = "Kral Şakir";
            richTextBox1.Text = "Laboratuvarda yapılan bir deney hiç beklenmedik sonuçlar doğurur. Deney sonucu Fil Necati’nin telefonundaki oyun ile gerçek dünya arasında bir kapı açılır. Şakir’in ne yapıp edip dünyayı kurtarması gerekir. Ailesi ile kendini Fil Necati'nin cep telefonunun içindeki oyunda bulan Şakir, gerçek dünya sona ermeden bütün oyunları tamamlayıp oyunu durdurmalıdır. Fakat bu hiç de düşünüldüğü kadar kolay olmaz. Şakir ve ailesi dünyayı kurtarmaya çalışırken bir yandan da onu durdurmaya çalışan düşman ve tehlikeli video oyun kahramanlarıyla da savaşmak zorunda kalır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/18/05/08/13/53/1546044.jpg";
        }

        private void aşkSanaBenzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=0EGFT3xzy9M");
            label1.Text = "Aşk Sana Benzer";
            richTextBox1.Text = "Ege'de bir balıkçı kasabasından ailesinden kalan restoranı elinde tutmak için mücadele veren Ali, bir gün kasabaya gelen ve esrarengiz bir kız olan Deniz ile karşılaşır. Birbirlerine karşı büyük bir çekim hisseden Deniz ve Ali'nin aşkına dondurmacıdan manava kadar kasabanın pek çok sakini şahittir. Bu sıcak Ege kasabası, kendisi gibi bir aşka tanıklık ederken, Deniz'in geçmişinden gelenler onun ve aşkının peşini bırakmayacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/14/12/19/14/02/551587.jpg";
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aQnlngjZG48");
            label1.Text = "Aynı Yıldızın Altında";
            richTextBox1.Text = "16 yaşındaki Hazel üç yıldır tiroid kanseriyle boğuşmaktadır ve kanser akciğerlerine de sıçradığı için yanında bir oksijen tüpüyle gezmektedir. Kanserli hastalar için oluşturulan destek grubunun bir terapi seansı esnasında Augustus isimli bir gençle tanışır. Augustus da beyin tümörüyle savaşmış ve bu yolda bir bacağını kaybetmiştir. İkili birlikte zaman geçirdikçe birbirlerine aşık olurlar. Akciğer tedavisi için hastaneye yatırılan Hazel'ın yanından bir an dahi ayrılmayan Augustus, sevgilisinin çok istediği bir hayali gerçekleştirmek için onunla birlikte yola çıkar. Planlarına göre Amsterdam'a gidecek ve Hazel'ın en sevdiği yazar olan Peter Van Houten'i bulmaya çalışacaklardır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://www.kaanintavsiyesi.com/pictures/movies/902526/30/ayni-yildizin-altinda-the-fault-in-our-stars-420x600.jpg?v=9";
        }

        private void sevimliTehlikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=iqehAtntwZ0");
            label1.Text = "Sevimli Tehlikeli";
            richTextBox1.Text = "Zarok çok uzun yıllar önce Edirne’de henüz beşikteki bir kız çocuğunu kaçırıp, bir ailenin ömür boyu büyük acılar yaşanmasına neden olur. Aradan uzun yıllar geçer ve Zarok eline geçen bir fırsatı değerlendirir. Vicdan azabını hafifletmek için bu sefer, daha önce kaçırdığı kızı tekrar kaçırarak gerçek ailesine götürecektir! Fakat bu süreçte her iki karakteri de, aşk dolu bir macera beklemektedir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/14/11/14/14/40/492000.jpg";
        }

        private void delibalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=_A-k9FYBF5g");
            label1.Text = "Delibal";
            richTextBox1.Text = "Mimarlık öğrencisi olan ve hobi olarak müzik yapan Barış hayatın tadını çıkarmaktan keyif alan birisidir. Füsun’u ilk gördüğü anda hayatında hiç bilmediği bir duyguya kapılmıştır. Hep teğet geçen aşk bu defa Barış’ı yakalamıştır. Aşkı ona tattıran bu kız kimdir? İsmini bile bilmediği ama aşık olduğu bu kıza bir şekilde ulaşmak ister ve ulaşır da… Füsun’u bulmak, ulaşmak tamamdır da; aklında üniversiteyi derece ile bitirip Amerika’da master yapmaktan başka şey olmayan Füsun’u bir de aşka ikna etmek lazımdır. Yakışıklı, akıllı ve içten olan Barış, sonunda bunu da başarır. Füsun’u kendine aşık eder, evlenirler. Her şey masallardaki gibidir. Ta ki masal bir gün bozulana kadar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQD0a5_5V3qT4PxepUmkGotXw6AcMOU3a09gA&usqp=CAU";
        }

        private void aşkVeGururToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=0Le1mIbdjJU");
            label1.Text = "Bir Aşk İki Hayat";
            richTextBox1.Text = "Bir Aşk İki Hayat, basit bir konu hakkında yaptığı tercihlerle farklı yönlere savrulan bir adamın hikayesini konu ediyor. Umut, kendi filmlerini çekmeye çalışan, bağımsız bir yönetmendir. Moda'da köpeği ile birlikte yaşayan Umut'un hayatı, bir gece vereceği kararla bambaşka bir hal alır. Genç adam, hayatının değişeceğinden habersiz bir şekilde köpeği ile dışarı çıkmaya karar verdiğinde, hayatının aşkı ile tanışma fırsatı bulur. Aşk ve hayatın sonsuz seçenekleri arasında neyin doğru olduğunu bilmeden ilerleyen Umut, başarılı bir mimar olan Deniz ile tanışır. Diğer seçeneğe karar verdiğinde ise uçurumun kenarına sürüklenmesine neden olacak olaylar silsilesi başlar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/19/02/01/10/07/2640751.jpg";
        }

        private void aşkTesadüfleriSeverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=1qjMQ1xBldI");
            label1.Text = "Aşk Tesadüfleri Sever";
            richTextBox1.Text = "Yönetmenliğini Ömer Faruk Sorak’ın yaptığı Aşk Tesadüfleri Sever'; çocuklukları ve gençliklerinde yolları Ankara'da kesişen ve 2010 yılında İstanbul'da tekrar karşılaşan Özgür ve Deniz'in kendilerini engellerle dolu bir aşk macerası içinde buldukları hayatlarına odaklanıyor.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/9/91/A%C5%9Fk_Tesad%C3%BCfleri_Sever_Film_Afi%C5%9Fi.jpg";
        }

        private void masallardanGeriyeKalanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=x4rPY_TFmCE");
            label1.Text = "Masallardan Geriye Kalan";
            richTextBox1.Text = "Masallardan Geriye Kalan, üniversitede doçent olan bir adam ile yüksek lisans öğrencisi bir kız arasında yaşanan aşkı konu ediyor. Evren ve Hece arasında beklenmedik bir zamanda, hızla gelişen aşkı konu edinen filmde, aşkın karşı taraftan çok kişinin kendisiyle ilgili olduğu gözler önüne seriliyor.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/20/02/05/09/20/1858007.jpg";
        }

        private void ağırRomantikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=nZLOPJtQDOc");
            label1.Text = "Ağır Romantik";
            richTextBox1.Text = "Sanatla ilgili bir annenin ve profesör bir babanın kızı olan Aslı, konservatuvarda okumaktadır. Aslı'nın hayatı, bir gün Beyoğlu'nda yürürken bir kapkaççının çantasını çalması ile bambaşka bir hal alır. Yaşadığı olay sonrası büyük bir korkuya kapılan Aslı'ya, bu sırada olaya şahit olan Kerem adında bir adam yardım eder ve çantayı bularak Aslı'ya teslim eder. Bu tatsız olay sayesinde tanışan Aslı ve Kerem, görüşmeye devam ederek çok geçmeden güzel bir ilişkiye başlar. Ancak Kerem, ayrı dünyalara sahip olduğu sevgilisine kendisini bambaşka biri olarak tanıtır. Finans uzmanı olarak kendisini tanıtan Kerem, babasının İstanbul'un en büyük kapkaç çetesinin başı olduğu gerçeğini de gizler. Ancak yaşananlar, onların en mutlu günlerinin akıllarından hiç çıkmayacak bir güne dönüşmesine neden olur.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/20/02/06/12/30/1631210.jpg";
        }

        private void sendenBanaKalanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=UuUotpZXuhg");
            label1.Text = "Senden Bana Kalan";
            richTextBox1.Text = "Çocukluğunda annesiz ve babasız kalan Özgür, büyükbabasının mirası sayesinde zorluk görmeden, biraz da şımartılarak büyümüştür. Büyükbabasından kalacak olan miras sayesinde rahat ve sorumsuz bir hayat sürmeyi planlarken 18 yaşına bastığı gün işlerin hiç de umduğu gibi gitmeyeceğini öğrenir. Özgür mirası alabilmek için vasiyetnamede yazan bir şartı yerine getirmek zorundadır. Buna göre İstanbul'dan Çanakkale'nin Adatepe köyüne taşınacak ve burada bir yıl geçirecektir. Özgür bu şartı yerine getirmezse mirasın yalnızca ufak bir kısmını alabilecek, geri kalan kısmı ise hayır kurumlarına bağışlanacaktır. Mirası hak ettiğini düşünen Özgür, Adatepe'ye gider ve kendini bekleyen yeni hayata böylece atılmış olur. Adatepe'de onu büyük sürprizler beklemektedir. En büyük sürpriz ise beklenmedik bir anda hayatına giren Elif olacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/15/04/09/13/13/581651.jpg";
        }

        private void mutlulukZamanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7Z4H7e6FCJg");
            label1.Text = "Mutluluk Zamanı";
            richTextBox1.Text = "Mert, müşterilerini hayata karşı ayakları dimdik yere basan insanlara dönüştüren 'mutluet.com.tr ' şirketinin sahibidir. Geçmişiyle yüzleşmeden kendi mükemmel hayatını yaratan Mert ve tüm hayatını geçmişinde yaşadıkları üzerine kuran Ada'nın yolları sürpriz bir şekilde kesişir. Mert'in hayatı Ada'yı tanıdıkça değişmeye başlar. Mert'i tanıdıkça ona aşık olan Ada ise ne kadar duygularına engel olmaya çalışsa da başarılı olamaz. Kendisini hep kaybeden biri olarak gören Ada'nın ağabeyi Tarık'ın hayatı ise Mert'le tanıştığında bambaşka bir hal alır. Fakat ne Cengiz'in 'Mert'in kız kardeşine aşık olduğundan haberi vardır; ne de Ada'nın abisinin Mert'ten çapkınlık dersleri aldığından";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/17/10/25/12/18/3482480.jpg";
        }

        private void eltilerinSavaşıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=EGwPtioTEqE");
            label1.Text = "Eltilerin Savaşı";
            richTextBox1.Text = "Eltilerin Savaşı, iki elti olan Sultan ve Gizem arasında yaşanan tatlı çekişmelere, bitmek bilmeyen rekabete odaklanıyor. Gizem ve Sultan elti olan iki genç kadındır. İkili arasında yaşanan ufak atışmalar bir süre sonra yerini tatlı bir rekabete bırakır. Birbirlerinin yaptıklarından geri kalmayan eltiler, kendilerini eğlenceli bir savaşın içinde bulur. Kardeş olan Selim ve Fatih de bir süre sonra eşleri arasında yaşanan bu rekabet rüzgarına kapılır. Sosyal medyaya düşkünlükleri ile bilinen Gizem ve Sultan’ın evlilik hayatlarına odaklanılan filmde, iki eltinin yarış içindeyken Selim ve Fatih’i nasıl etkiledikleri de gözler önüne seriliyor.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/20/01/31/13/58/1528032.jpg";
        }

        private void kolonyaCumhuriyetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=dmWtv-WDZ8M");
            label1.Text = "Kolonya Cumhuriyeti";
            richTextBox1.Text = "Dünyaya gelen uzaylılara karşılama yapılır. Kolonya'ya iniş yapan uzaylı yerel halkın büyün sevgisiyle karşılanır ancak bir kaza olur ve kutlamalar sırasında uzay mekiği yerle yeksan olur. Kolonya'da bir müddet konaklamak zorunda kalan uzaylı ile yerel halkın arasında da kahkaha dolu bir macera başlar. Uzaylının inişiyle birlikte Amerika da tepkisiz kalmaz ve beş bin nüfuslu beldeye savaş açar. Artık işler iyice karışacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/17/03/30/10/32/361612.jpg";
        }

        private void amanReisDuymasınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=9PRP_4h2sV4");
            label1.Text = "Aman Reis Duymasın";
            richTextBox1.Text = "Aman Reis Duymasın filmi, yeraltı mafya camiasının çıktığı bir tatili konu ediniyor. Eşkıya Dünyaya Hükümdar Olmaz dizisinden tanıdığımız karakterler, tatil için gittikleri yere adımlarını atar atmaz inanılmaz olaylarla karşılaşırlar. Ancak bu onları yıldırmaz ve tatillerine devam ederler. Alışkın oldukları büyük şehrin atmosferinden eser burada yoktur. Küçük bir kasaba olan tatil merkezinde başlarına gelmeyen kalmayacaktır. En büyük korkuları ise liderleri Hızır Çakırbeyli'nin bu olanları duyacak olmasıdır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/19/11/08/11/36/3405516.jpg";
        }

        private void ailecekŞaşkınızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=DQfMbGMgH-0");
            label1.Text = "Ailecek Şaşkınız";
            richTextBox1.Text = "Babasının şirketinin başına geçerek CEO’luk görevini üstlenen Ferhat şımarık bir adamdır. Hala çocuksu yapısıyla dikkat çeken Ferhat'ın sağ kolu ise onun çocukluk arkadaşı, şirketin finans müdürü Gökhan'dır. İkili çalışanlarına pek de nazik davranmamaktadır. Günün birinde şirket çalışanlarına yemek servisi için gittikleri bir restoranda, restoran sahibiyle dostluk kurarlar. Restoran sahibinin kızı Elif'e gönlünü kaptıran Ferhat, deliler gibi aşık olur. Ancak Elif narin ve saf bir genç kız değildir. Özel eğitimler ve üstün hizmetlerle dolu kariyeri, sert karakteri ve kıvrak zekası, Ferhat'ı bir hayli zorlayacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/18/01/26/08/59/2889648.jpg";
        }

        private void düğünDernekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=DjxirzxarNU");
            label1.Text = "Düğün Dernek";
            richTextBox1.Text = "Sivas'ın Esenyurt köyünde yaşayan İsmail'in oğlu Tarık bir gün yurt dışından çıkagelir. Önce her zamanki gibi bir memleket hasreti gibi görünse de bu ziyaretin altındaki esas neden çabuk ortaya çıkar: Tarık görevli olarak çalıştığı Letonya'da Monica adlı bir kızla beraberdir ve aynı ülkede çalışmak için tek yol evlenmeleridir! Kendisinin olurunu almaya gelen oğlunu düğünsüz evlendirmemeye kararlı olan İsmail, alelacele bir düğün telaşına girer. Ama çok hazırlıksız yakalanmıştır. yine de 'Ben oğluna düğün yapamadı dedirtmem!' diyerek Tüpçü Fikret'i, Çetin'i ve köyün öğretmeni Saffet’i seferber ederek elde avuçta para yokken 10 gün içerisinde sazlı-sözlü bir düğün hazırlığı içerisine girer! Fikret Sivas'taki 'bağlantılarını' kullanarak önce bir otel düğünü için söz verse de, işler sarpasarar ve köy meydanında mütevazi bir düğün hazırlığı başlar. Tam her şey çözüldü derken, esas curcurna düğün gecesi kopacaktır. Devenin sırtında kaybolan gelinden, Rusya'dan gelini geri götürmeye gelen mafyaya kadar Tüpçü Fikret ve Çetin'i bin tane bela beklemektedir! ";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://3.bp.blogspot.com/-z9FoX6uJh4g/XBaBzHx-ybI/AAAAAAAAAAM/LhO4mOtuJNYe7GZTU0HRv1eqmqIZK2vnwCEwYBhgL/s1600/1455037697.258734jpg.jpg";
        }

        private void bayiToplantısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=bcgDQB1n47g");
            label1.Text = "Bayi Toplantısı";
            richTextBox1.Text = "Bayi Toplantısı, mecburen katıldıkları bayi toplantısında kendilerini birbirinden eğlenceli maceraların içinde bulan üç beyaz eşya satıcısının hikayesini konu ediyor. Namık, Adem ve Sadık, geçimlerini efnaflık yaparak sağlayan üç adamdır. Birbirlerini tanımayan bu üç adamın yolu katıldıkları bayi toplantısında kesişir. Hayatlarının zor bir döneminden geçen Namık, Adem ve Sadık, başlarına gelen olaylar sonrasında kendilerini macera dolu bir planın içinde bulur. Bayilerini kurtarmaya çalışan ekibin bu süreçte birbirine güvenmekten ve hızlı etmekten başka çaresi yoktur.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/20/01/16/18/10/0488218.jpg";
        }

        private void ferideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=3TBeIj4wbSE");
            label1.Text = "Feride";
            richTextBox1.Text = "Feride, moda devlerine kafa tutan genç bir kadının hikayesini konu ediyor. Genç bir kadın olan Feride, yer altındaki bir dikim atölyesinde terzilik yapmaktadır. Çakma kahraman kıyafetleri diken Feride’nin hayatı, bir gün patronu ile iddiaya girmesi ile bambaşka bir hal alır. Patronu Çetin’e baş kaldıran ve bunun sonucu patronu ile büyük bir iddiaya giren Feride, kendisini bir anda moda devlerine kafa tutan eğlenceli bir yolculuğun içinde bulur.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/19/12/18/12/14/5872106.jpg";
        }

        private void şahaneHayallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CkDO-nKIBF8");
            label1.Text = "Şahane Hayaller";
            richTextBox1.Text = "Şahane Hayaller, şair olmak isteyen bir adam ve onun menajerliğini yapmaya çalışan arkadaşının hikayesini konu ediyor. Ömer, şair olmak isteyen genç bir adamdır. Yıllardır hayalini gerçekleştirmeyi bekleyen Ömer, bu nedenle hayatını boşa geçirir. Hiçbir baltaya sap olamayan genç adam, zaman içinde hayalinden uzaklaşır. Tam da bu sırada liseden bir arkadaşı olan Ali ile karşılaşır. Ömer, Ali sayesinde yeniden hayaline tutunur. Ali'nin asıl amacı Ömer'in hayaline kavuşmasını sağlamak değil, onun menajerliğini yapıp sırtından para kazanmaktır. Ancak Ali'nin Ömer'in menajerliğini yapmasını sağlayacak bilgisi ve çevresi yoktur. Ömer'in kitabını bastırmak için türlü yılları deneyen ikili, kendilerini eğlenceli bir maceranın içinde bulur.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/20/01/03/07/56/3996862.jpg";
        }

        private void aykutEnişteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vSLqy50b0lE");
            label1.Text = "Aykut Enişte";
            richTextBox1.Text = "Aykut Enişte, yalnızlığından şikayetçi olan ve aile özlemi çeken bir adam olan Aykut'un hikayesini konu ediyor. Aykut, evlenip yuva kurmanın hayali ile yaşayan genç bir adamdır. Sevgili Nurhan ile hayallerini gerçekleştirmeye adım adım yaklaşan Aykut, beklenmedik bir durumla karşı karşıya kalır. Düğüne bir hafta kala dükkanına hırsız giren Aykut, tüm birikimini kaybeder. Dükkana hırsızın girmesi, sadece Aykut’un maddi kaybına neden olmaz aynı zamanda başına türlü işler açılmasına da neden olur. Dükkana bakmak için sigortadan gelen Gülşah'ın, Aykut’tan küçük bir iyilik istemesi hepsinin hayatının değişmesine neden olur. Kendi halinde kimsesiz bir adam olan Aykut, bir anda kendisini iki ailenin damadı olarak bulur. Aykut, içine düştüğü bu karışık durumdan kendisini kurtarmayı başarabilecek midir?";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/19/05/10/11/02/3221396.jpg";
        }

        private void babaParasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=PaKx4EzYaXg");
            label1.Text = "Baba Parası";
            richTextBox1.Text = "Ülkenin en zengin insanının gayri meşru çocukları, babalarının ölümü üzerine büyük bir servete konar. Birbirinden farklı karaktere, kültüre, yaşam tarzına sahip olan kardeşler, kendilerine düşen payı almak için harekete geçtiklerinde beklenmedik bir durumla karşı karşıya kalır. Kardeşler, yasal varis olmalarına rağmen, mirasın tamamına sadece biri sahip olabilecektir; en kötü olanı. Babalarının mirasının bulunduğu kasanın şifresini bulan, tüm mirasın sahibı olacaktır. Şifre ancak ölen milyarder gibi aç gözlü, düzenbaz, acımasız, zeki ve uçarı biri tarafından bulunabilecektir. Kasayı açmak için büyük bir yarışa girişen kardeşler, bu süreçte kendilerini beklenmedik durumların içinde bulur.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/19/12/02/09/05/5713126.jpg";
        }

        private void hızlıVeÖfkeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=b98rYy66Idk");
            label1.Text = "Hızlı ve Öfkeli 9";
            richTextBox1.Text = "Dominic Toretto’nun artık tek önceliği oğlu Brian’ı korumaktır. Oğlu ve Letty ile birlikte sakin bir yaşam süren Toretto, istese de geçmişinden kurtulamaz. Bu kez geçmişi ile yüzleşmek zorunda kalan Toretto, siber suçlu Cipher ile birlikte çalışan kardeşi Jakob’a karşı savaşmak zorunda kalır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/20/02/03/07/33/0819087.jpg";
        }

        private void tetikçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=i3A0ptNnC5s");
            label1.Text = "Tetikçi";
            richTextBox1.Text = "En iyi olduğu alanda artık işi bırakmış olup da tecrübesine ihtiyaç duyulan olmak. Mark Wahlberg, bir zamanların ün salmış kusursuz nişancılarındadır. Bu işleri bırakmış olmasına rağmen bir gün önemli bir son görev için kendisinden destek istenir. Mark, bu işi kabul ettiğinde kısa sürede görevin altında yatan esas hedefi kavrayacaktır. Kendisine görevi verenlerin esas amacı Amerikan Başkanı’na bir süikast düzenlemektir. Bu şartlar altında Mark’ın misyonu tamamen değişir. Onun amacı artık bu komplonun sırlarını çözmek ve Başkan’ı başına geleceklerden yana korumaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/01/77317.jpg";
        }

        private void shorlockHolmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=cij6sH15bz8");
            label1.Text = "Sherlock Holmes";
            richTextBox1.Text = "Dünyanın en ünlü ve zeki dedektiflerinden Sherlock Holmes (Robert Downey Jr.) ve 'ortağı' Dr. Watson (Jude Law) bu sefer Londra’nın dışına çıkarak Fransa, Almanya ve İsviçre’ye yol alacakları yeni ve tehlikeli bir maceraya sürükleniyorlar. Onlardan hep bir adım önde olan kurnaz ve vicdansız Profesör Moriarty (Jared Harris) ise -ki Holmes en zeki olma unvanını ona kaptırmak üzere- büyük bir laneti değiştirecek planların peşindedir. Kahramanlarımız ise ne olursa olsun Moriarty durdurmaya kararlı.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/pictures/bzp/01/173048.jpg";
        }

        private void donmaNoktasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=88K71ZcuhHs");
            label1.Text = "Donma Noktası";
            richTextBox1.Text = "Sert soğuğun hakim olduğu bir akşamda polis abimiz Martin ve meslektaşı Montesinos, mahkumların hapishaneye nakil edilmesi için yola koyulurlar. Ancak yolda beklemedikleri bir saldırı ile karşılaşırlar. 2 polis memuru ve 6 mahkum, hasar alan aracın içine kısılmış durumdadırlar. Soğuğun kendisini iyice göstermeye başladığı sırada eski polis olan saldırganımız Miguel, isteğini söylemiştir. Kimseyi öldürmek istemediğini, sadece bir mahkumu canlı istediğini belirtmiştir. Kanun adamı Martin abimizin ise kimseyi vermeye niyeti yoktur.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://www.hdfilmcehennemi.net/wp-content/uploads/Screenshot_24.png";
        }

        private void görevimizTehlikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7xJh2go7Udo");
            label1.Text = "Görevimiz Tehlike";
            richTextBox1.Text = "Tehlikeli bir operasyonun ters gitmesi sonucu usta casus ekibinin lideri CIA'e bir köstebek sızdığını keşfeder. Bir numaralı şüpheli ise bizzat kendisidir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img3.acsta.net/c_310_420/pictures/bzp/01/15308.jpg";
        }

        private void nöbetçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=LOvzWjQkE1U");
            label1.Text = "Nöbetçi";
            richTextBox1.Text = "Ateş hattındaki travmatik bir görevin ardından eve gönderilen iyi eğitimli bir Fransız asker, kız kardeşine saldıran adamı yakalamak için ölümcül yeteneklerini kullanır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://www.hdfilmcehennemi.net/wp-content/uploads/Sentinelle-Nobetci-izle.jpg";
        }

        private void johnWickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=l1g0fn5Nm_g");
            label1.Text = "John Wick";
            richTextBox1.Text = "John Wick, emekliye ayrılmış bir tetikçidir. Emekliliğinin tadını çıkarırken karısının yakalandığı amansız hastalıkla hayatı altüst olur. Karısından kendisine kalan en değerli varlığı ve can yoldaşı köpeğidir. Ancak evine dalan üç gangster onu da öldürür. Gansterlerden biri, mafya babası Viggo Tasarov'un oğlu Josef Tasarov'dur ve John'un daha önce birlikte çalıştığı bir adamdır. Artık kaybedecek hiçbir şeyi de kalmayan John Wick'in tek istediği intikamdır ve New York sokaklarında düşmanlarıyla nefes kesen bir kovalamacanın içine girer.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://i.pinimg.com/originals/30/33/20/3033200da07e191f8d9ec0a0b8381f19.jpg";
        }

        private void extractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=IEPe3cpjVtY");
            label1.Text = "Extraction";
            richTextBox1.Text = "Korkusuz bir karaborsa paralı askeri olan Tyler Rake, hapsedilmiş bir uluslararası suç lordunun kaçırılan oğlunu kurtarmak için askere alındığında kariyerinin en ölümcül çıkarımına başlar.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://m.media-amazon.com/images/M/MV5BMDJiNzUwYzEtNmQ2Yy00NWE4LWEwNzctM2M0MjE0OGUxZTA3XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg";
        }

        private void uyumsuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=PtyQddvAbFI");
            label1.Text = "Uyumsuz";
            richTextBox1.Text = "Uzak bir gelecekte geçen distopik hikayede insanlık, her biri farklı bir erdemi temsil eden beş farklı parçaya bölünmüş bir düzende yaşamaktadır. İnsanlar 16 yaşına geldiklerinde kendi insani özelliklerine göre bu beş bölümden birine dahil olup ömür boyu bu bölümde yaşamlarını sürdürmektedirler. Tris Prior için de bu kuralı uygulama zamanı geldiğinde kendiyle ilgili büyük bir sırrı keşfeder: Tris, 'uyumsuz'dur ve herhangi bir gruba ait olması mümkün değildir. Asıl sorun ise uyumsuzların bir lider tarafından yok edildiği ve bu yüzden hayatını kurtarabilmek için kaçması gerektiği gerçeğiyle yüzleştiği an ortaya çıkar. Tris bu belalı yolculukta hem hayatta kalabilmek hem de kendisi gibi uyumsuzların bu düzende neden bu denli tehlikeli bulunduklarını öğrenebilmek için Four adlı gizemli bir yabancıya güvenmek ve onunla işbirliği yapmak zorunda kalır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/14/04/15/13/51/015977.jpg";
        }

        private void tombRaiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ouG9OtZgZ9c");
            label1.Text = "Tomb Raider";
            richTextBox1.Text = "Babasının ortadan kaybolmasından yedi yıl sonra, 21 yaşındaki Lara küresel ticaret imparatorluğunun başına geçmeyi reddetmiş ve üniversite dersleri alırken bir yandan da Londra'da bir bisiklet kuryesi olarak çalışmaktadır. Ancak ortaya çıkan yeni bir antik eser sonucu babasının kayboluşunu araştırmaya başlar ve son gittiği yeri ziyaret eder: Japonya kıyılarında bir yerde bulunan gizemli bir adadaki bir mezar. Birdenbire Lara kendini yalnızca keskin zekası, dirayeti ve inatçı ruhuyla silahlanmış bir halde, dezavantajlı bir durumda olduğu bir maceranın içinde bulur. Lara, bilinmeyene doğru yolculuk ederken, kendi sınırlarının ötesine geçmeyi de öğrenmelidir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://image.api.playstation.com/vulcan/img/cfn/11307GuAHH7iQiOD4izIk0LfwiEqxk8YuSh6_6z4bBNpNiakl7J0slnPcDaZ3MTFoT0bCw0D0iLyFrXhc8Au0FGTv80hw0wU.png";
        }

        private void yüzüklerinEfendisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=USNqsrW5DrQ");
            label1.Text = "Yüzüklerin Efendisi";
            richTextBox1.Text = "Yüzük Kardeşliği, dünyanın kaderini değişterecek olan yüzükten kurtulmak için verilen mücadeleyi konu ediyor. Yıllar önce üretilen ve Orta Dünya topraklarına kandan başka hiçbir şey getirmeyen yüzüklerin sonuncusu, üretiminden yüz yıllar sonra ortaya çıkar. Amcasının kendisine emanet ettiği yüzüğün nelere kadir olduğundan habersiz olan Frodo, büyücü Gandalf'ın anlattıkları sonrasında dehşete kapılır. Bu yüzükten ve müstakbel savaşlardan kurtulmanın tek yolu, gücünü toplamaya çalışan Sauron'u da engellemek için bu yüzüğü yok etmektir. Yüzüğü yok edilebileceği tek yer olan Mordor'a götürmek için kendini feda eden savaşçılardan oluşan bir ekip oluşturulur. Çok uzun ve çetin geçecek olan yolculuk başlar. Orta Dünya'nın kaderi, bu insanların ellerindedir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/01/27070.jpg";
        }

        private void ölümsüzlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hG2YdKnzlJk");
            label1.Text = "Ölümsüzler";
            richTextBox1.Text = "Antik Yunan'da geçen filmde, savaşçı prens Theseus kötü güçlere karşı savaş açar; tanrılar ve insanlar, titanlara ve barbarlara karşı mıdır? Mickey Rourke'nin canlandırdığı Titan Hyperion, yıllar sonra insanlığa savaş açar. Savaş Tanrısı Ares tarafından üretilen efsane bir silahın, Epirus Yayı'nın peşindedir. Bu silah, Titanları Tartaruslardan kurtarmaya yarayacaktır, bu silah sayesinde öç alabilecektir. Tanrılar savaşta Hyperionlar ya da insanlık arasında bir seçim yapma yetisine sahip değildirler, taraf tutamamaktadırlar. Tanrıları ve toprağını korumakla görevli olan Theseus'tur ve onu da Zeus seçmiştir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/medias/nmedia/18/86/26/26/19831918.jpg";
        }

        private void örümcekAdamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=l6WEvHsvzOQ");
            label1.Text = "Örümcek Adam";
            richTextBox1.Text = "Örümcek-Adam: Evden Uzakta, arkadaşları ile gittiği okul gezisi sırasında gizemli bir görev üstlenmek zorunda kalan Peter Parker'a odaklanıyor. Örümcek Adam macerasının 2. devam halkası olan filmde Peter Parker’ı bir kez daha milyonlarca hayran kazanan yeni nesil Örümcek Adam Tom Holland canlandırıyor.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/19/06/21/09/39/5802960.jpg";
        }

        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=m8e-FF8MsqU");
            label1.Text = "Matrix";
            richTextBox1.Text = "Bir yaşanan gerçek vardır, bir de yaşananın ötesinde olan gerçeklik... Biri rüya, diğeri ise Matrix! Neo,son derece tehlikeli bir adam olan Morpheus’un gerçeği bildiğine inanmaktadır. Bir gece Neo, kendisini başka bir dünyaya götürebilecek güzel yabancı Trinity ile tanışır. Bu kızın götüreceği dünyada, Neo Morpheus’u bulacak ve Matrix hakkında bir şeyler öğrenecektir. Neo, Tam olarak kavrayamadığı şeylerin yaşamını kontrol ettiğini biliyor.. Nedir bu Matrix?";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg";
        }

        private void açlıkOyunlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ul1j1vrXegw");
            label1.Text = "Açlık Oyunları";
            richTextBox1.Text = "Katniss Everdeen'in distopik ve bir o kadar da despotik dünyada geçen hayatta kalma hikayesi, serinin ikinci filminde de devam ediyor. Katniss ve yoldaşı Peeta 74. Açlık Oyunları'nı kazandıktan sonra sorunsuz bir şekilde evlerine dönmeyi başarırlar. Ancak bu galibiyet her şeyden önce Zafer Tutu yapmalarını gerektirmektedir. Her bölgeyi ayrı ayrı ziyaret ettikleri bu yolculuk sırasında Katniss, büyük bir ayaklanmanın ilk işaretlerine şahit olur. Başkaldırmanın ilk ipuçlarını gören Başkan Snow ise direnişi engelleyecek çareler aramaya başlar. Yeni Açlık Oyunları ile ilgili beklenmedik 'sürprizler' tasarlayan Snow 75. yılını kutlayacak Açlık Oyunları'nda, 25 yılda bir düzenlenen Çeyrek Asır Oyunları'nın (Quarter Quell) üçüncüsünün yapılacağını duyuracaktır. Galibiyetinin tadına dahi varamadan yeni bir hayatta kalma mücadelesine sürüklenen Katniss bu kez Açlık Oyunları'nın en yeteneklileri ve zekileri arasında hayatta kalmak için savaşacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://i.pinimg.com/originals/30/86/b1/3086b146666e63ff08698f198cfd4974.jpg";
        }

        private void jurassicParkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=qP7KM1zPPxY");
            label1.Text = "Jurassic Park";
            richTextBox1.Text = "Claire’in parkı yönetirken birer market ürünü gibi gördüğü dinozorlara olan bakış açısı değişir ve 'Dinozor Koruma Grubu' isimli bir organizasyon kurar. Amacı; aktif bir yanardağın harekete geçtiği adada yaşayan dinozorları adadan çıkarmanın bir yolunu bulmaktır. Claire, bu tehlikeli ve zor görevi yerine getirebilmek için de dinozorlara karşı baskınlığını kanıtlamış olan tanıdığı tek kişiden, Owen Grady'den yardım ister. İkilinin bir kurtarma görevi amacıyla gittikleri adada ise her şey sarpa saracaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://im.haberturk.com/2018/06/06/ver1528446383/2002915_ad0233f06755edc92ebd878e78c07ac1.jpg";
        }

        private void hulkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=a6tdpDPLQ2U");
            label1.Text = "Hulk";
            richTextBox1.Text = "Bruce Banner'ın lideri olduğu çok gizli bir proje, ülkenin çeşitli yerlerinden getirilen kimi deha öğrencilerin de katkılarıyla, son demlerine ulaşmıştır. Projeyi test etmek amacıyla yapılan deneyde büyük bir kaza meydana gelir ve Bruce Banner, yüksek miktarda radyasyona maruz kalır. Gama ışınları nedeniyle mutasyon geçiren Banner, artık ne zaman sinirlenirse yeşil ve dev bir yaratığa dönüşmektedir. Artık elindeki tek şansı, kontrol edemediği bu gücü bir şekilde içinde sindirmek olacaktır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img4.acsta.net/pictures/bzp/01/34509.jpg";
        }

        private void tranformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=VEgZnEbr3BM");
            label1.Text = "Transformes";
            richTextBox1.Text = "Autobot ve Decepticon'lar arasında yaşanan son savaşın ardından dört yıl geçer. Savaşta Chicago şehri yerle bir edilmiş ve binlerce insan öldürülmüş olsa da dünya ve insanlık büyük bir tehditten kurtulmuş olur. İnsanlık yaralarını sarmaya çalışırken Amerikan hükümeti de Autobotlar ile arasındaki ilişkiye iyice koparmış, hatta hayatta kalanları yok etmeleri için CIA'de özel bir birim dahi kurulmuştur. Teksas'ta kendi halinde bir tamirci olan Cade Yeager, eline geçen hasarlı bir kamyoneti, parçalarını satma umuduyla kabul eder. Ne var ki bu kamyonetin yaralı bir Optimus Prime'dan başkası olmadığını anlaması uzun sürmez. Optimus Prime'dan aldıkları sinyallerle yola çıkan CIA ajanlarıyla başının derde girmesi de çok yakındır. Cade Yeager bir şekilde Optimus Prime'ı Chicago'ya ulaştırmak ve diğer Autobotlar ile iletişime geçmesini sağlamak zorundadır. Zira dünyayı tehdit eden güçlü bir düşman yola çıkmak üzeredir. Optimus Prime ve Autobotlar, Cade Yeager başta olmak üzere kendilerine destek olan insan topluluğunun yardımıyla başlarına gelen en korkutucu düşmanla yüzleşmek zorundadır.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/4/4a/Transformers-kayip-cag.jpg";
        }

        private void kingKongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=PzzErr9LBIM");
            label1.Text = "King Kong";
            richTextBox1.Text = "Hiç kimse bu adada karşılaşacakları şeylerden haberdar değildir. Neden bu denli gizemli olduğunu da bilmezler ama kısa süre içinde bunun cevabını bulacaklardır. Bu gizli adada yaşayan bir dev goril vardır ve bu vahşi hayvan ansızın Ann’i ele geçirir. Ona aşkla bağlanır. Carl ve Ann’in yeni aşkı Jack Driscoll, birlikte ormanın derinliklerine girip King Kong’u ve Ann’i bulmak zorundadırlar. Üstelik onları türlü yaratıklar beklemektedir. Carl’ın aklına başka bir plan gelir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/tr/7/78/Kingkong_2005_film_posteri.jpg";
        }

        private void yıldızlarArasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=4T4wxDnTYLg");
            label1.Text = "Yıldızlar Arası";
            richTextBox1.Text = "Yıldızlararası'nda, teknik bilgisi ve becerisi yüksek olan Cooper, geniş mısır tarlalarında çiftçilik yaparak geçinmektedir; amacı iki çocuğuna güvenli bir hayat sunmaktır. Onlarla yaşayan Büyükbaba Donald çocuklara göz kulak olurken, henüz 10 yaşındaki kızı Murph şaşırtıcı bir zekaya sahiptir. Geçmişte bıraktığı biliminsanı kariyerini özleyen Cooper'un karşısına bir gün beklenmedik bir teklif çıkar ve ailesinin, dahası insanlığın güvenliği için zorlu bir karar alması gerekir.";
            label1.Visible = true;
            richTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "http://tr.web.img2.acsta.net/pictures/14/10/09/15/52/150664.jpg";
        }
    }
}
