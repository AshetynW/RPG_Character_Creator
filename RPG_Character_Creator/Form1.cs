using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Character_Creator
{
    public partial class Form1 : Form
    {
        public Player newPlayer = new Player();
        public string[] names = new string[] { "Albelin","Altard","Arundel","Auber","Aungier","Bachiler","Bainard","Barkentin","Baudry","Bauquemare","Beaumarchais","Becdelièvre","Bellecote","Beringar","Bertran","Blangi","Bohon","Boissel","Bolbec","Bonenffant","Bordel","Bosiet","Boteler","Bouchard","Bourdet","Brai","Brereton","Bretteville","Brinon","Brix","Bulli","Buron","Busquent","Caillot","Cambrai","Canouville","Cardon","Carteret","Cavelier","Challenge","Chauncy","Cioches","Clinchamps","Colombelles","Conteville","Corbon","Corviser","Couer","Courci","Courseume","Croc","Cul de Louf","Curteys","d'Aguillon","Dalyngridge","Damours","d'Angers","Danneville","Darcy","D'Argouges","d'Arques","d'Auberville","d'Aumale","D'Auvay","d'Avre","de Bans","de Beauchamp","de Beaumont","de Bellemare","De Berchelai","de Bernieres","de Bethencourt","de Blays","de Bourgueville","de Calmesnil","de Challon","de Corbeil","de Courseilles","De Felius","de Gosbeck","de Hattes","de La Champagne","de La Noue","de La Reue","de Lombelon","de Maromme","de Mesnildo","de Montchrestien","de Moustiers","de Pardieu","de Recusson","de Roncherolles","de Savage","de Seyssel","de Toeni","de Vaux","de Viuepont","d'Engagne","des Vaux","Desmares","d'Eu","d'Hericy","d'Incourt","d'Ivri","d'Orbec","Douai","Druel","du Bosc-Roard","Du Gouey","du Perche","du Saussai","Dubosc","Duhamel","Dupasquier","Durerie","Duval","Elers","Erquemboure","Evelyn","Faintree","Faucon","Ferrieres","Fitzherbert","Flambard","Fonnereau","Fougeres","Fresle","Fromentin","Gand","Gibard","Gilpin","Godart","Gouel","Grai","Grenteville","Grimoult","Guéribout","Guideville","Guinand","Hachet","Hamage","Hauville","Herbard","Hewse","Hotot","Hynde","Jubert","la Cleve","la Mare","La Vache","Laci","Lallement","l'Appeville","Le Barge","le Blond","Le Chandelier","Le Cordier","Le Doulcet","Le Goix","Le Jumel","Le Marchant","Le Masson","Le Pesant","le Roux","le Senechal","le Vicomte","Letre","Libourg","Linesi","Lorz","Louvet","Ludel","Machel","Malet","Mallilie","Malveisin","Manneilli","Marchés","Marescot","Marillac","Mathan","Mauduit","Mautravers","Mercier","Mesnage","Meverel","Moion","Montaigu","Montfiquet","Montgommeri","Mortagne","Mortmain","Munneville","Musart","Nelond","Neufmarche","Omand","Osmond","Painel","Pantoul","Paris","Paschal","Patris","Peche","Perci","Petremol","Picard","Pierrepont","Pippery","Pithou","Poignant","Pont","Port","Prestcote","Quièvremont","Rainecourt","Raoullin","Rennes","Reviers","Roard","Romé","Rosai","Runeville","Sainte-d'Aignaux","Saint-Leger","Saint-Sanson","Saisset","Séguier","Sept-Meules","Somneri","Stukely","Taillepied","Thaon","Thiboust","Tilly","Toclive","Tourlaville","Tournebulle","Toustain","Tulles","Valognes","Vaubadon","Vavassour","Ventris","Vernold","Vesci","Vieuxpont","Vipont","Vitalis","Voisin","Watteau","Wissant","Bigod","Cecil","de Braose","de la Pole","Devereux","Ferrers","Herbert","Montague","Neville","Russell","Stanley","Vane","Beauchamp","Adeney","Alevi","Ansgot","Aschuill","Aubert","Auvray","Baignard","Baliol","Basnage","Baujot","Bavent","Beaumont","Bele","Belmis","Berners","Bigot","Blosbeville","Boisivon","Boivin","Bondeville","Boneth","Bosanquet","Bossard","Boterel","Bourchier","Bourneville","Braund","Bretel","Brèvedent","Briouse","Buci","Burci","Bursigni","Caen","Cairon","Campion","Caradas","Cardonell","Castillon","Ceauce","Chandos","Cheney","Claville","Coliar","Colombieres","Corbet","Cormeilles","Cosin","Courcelle","Courcon","Craon","Cruel","Culai","d'Ouilli","d'Albert","d'Amboise","d'Andeli","d'Angerville","d'Ansleville","Darell","d'Argues","d'Athenous","d'Audrieu","Daunger","D'Auvrecher","de Bailleul","de Bapaumes","de Beaufou","de Beauvais","de Bellièvre","de Bercheres","de Berranger","de Bienfaite","de Blundville","de Breos","de Caulmont","de Chefderue","de Cormeilles","de Croismare","De Fry","de Grieu","de Herle","de La Hay","de La Place","de La Roche","de Lorraine","de Massard","de Monchy","de Montfault","de Moy","de Perronet","de Rely","de Salynges","de Seguzzo","de Tanie","de Valles","de Vesci","de Vymont","d'Eresby","d'Escalles","d'Espagne","d'Evreux","d'Houdetot","Ditton","Dol Hugue","d'Orglande","Dreux","du Bec","du Breuil","du Merle","Du Perron","du Theil","Dufay","Dumont","Duquesne","Durjardin","Dyel","Emory","Espec","Eveque","Falaise","Fecamp","Feu","Fitzhugh","Folet","Fontemai","Fourneaux","Fribois","Furnival","Garin","Giffard","Giscard","Godefroy","Goulaffre","Grancourt","Greslet","Grouchet","Guernon","Guiffart","Gurney","Halacre","Harcourt","Hédiart","Heriet","Hodenc","Hue","Ide","la Berviere","la Foret","la Pommeraie","La Verrier","l'Adoube","l'Ane","l'Archer","le Berruier","le Bouguignon","Le Clerc","Le Cornu","le Flamand","Le Grant","Le Lieur","le Marechal","Le Paulmier","le Poitevin","Le Roux","Le Sueur","Lefebre","Levasseur","Ligonier","Lisieux","Loucelles","Lovet","Lynom","Maci","Mallebisse","Mallory","Maminot","Mansel","Marchmain","Margas","Marisco","Maubenc","Maunsell","Maynet","Meri","Meulan","Middleton","Monceaux","Montbrai","Montfort","Moron","Mortain","Moyaux","Murdac","Mussegros","Neot","Neuville","Orlebar","Osmont","Paixdecouer","Papelion","Parry","Pasquier","Paumera","Peis","Péricard","Peveril","Picot","Pinel","Piquiri","Plucknet","Poillei","Pont de l'Arche","Postel","Puchot","Quincarnon","Raleigh","Rassent","Renold","Riebou","Rocque","Romenel","Rou","Sacquerville","Saint-Germain","Saint-Ouen","Saint-Valeri","Sauvigni","Senarpont","Simnel","Sourdeval","Tabraham","Talvace","Theroulde","Thorel","Tinel","Torteval","Tourmente","Tournebut","Tranchant","Urry","Vastel","Vauville","Veci","Ver","Vernon","Vesli","Villehardain","Vis-de-Louf","Vivers","Wadard","Werables","Ygou","Bohun","Courteney","de Burgh","de Lacy","Dudley","Fiennes","Howard","Mortimer","Percy","Sidney","Talbot","Vaughan","Aguilon","Alis","Anzeray","Asselin","Auffrye","Azor","Bailleul","Ballard","Basset","Bauldry","Beaumanoir","Beauvallet","Belet","Benoist","Bernières","Blancbaston","Blouet","Boislevesque","Bolam","Bonel","Bonvalet","Bosc","Bostel","Botin","Bourdekin","Bradwardine","Brebeuf","Breteuil","Brimou","Briqueville","Budi","Burguet","Busnois","Cailli","Calmette","Canaigres","Carbonnel","Carnet","Caunter","Cely","Chartres","Cherbourg","Clerinell","Colleville","Comyn","Corbière","Corneilles","Couci","Courcelles","Courcy","Crevecoeur","Cugey","Cumin","d'Adreci","d'Alencon","d'Ambray","d'Andre","d'Angleville","Danvers","d'Argentan","d'Armentieres","d'Aubernon","d'Aufai","d'Aunon","d'Avranches","de Balon","de Barbes","de Beaumais","de Bellehache","de Belmeis","de Bernai","de Berville","de Biville","de Bouilon","de Cahaihnes","de Caux","de Civille","de Coucy","de Faicterau","de Genville","de Hanivel","de Ireby","de La Mare","de La Porte","de Lampérière","de Malhortye","de Mesniel","de Monluc","de Montgomery","de Munchesney","de Pinchemont","de Reymes","de Saussay","de Servian","de Tocni","de Vandes","de Villy","d'Ecouis","des Moutiers","Deschamps","Destain","d'Helion","Digby","Dive Beugelin","d'Olgeanc","d'Ornontville","Droullin","du Bois-Hebert","Du Buisson","Du Moucel","du Quesnai","du Tilleul","Dufour","d'Unepac","Durandal","Durville","Ecouland","Engerrand","Esteney","Faceby","Fantosme","Fergant","Fitzalan","Fitzroy","Foliot","Fossard","Framan","Froissart","Gael","Gaveston","Gillain","Glanville","Gomboult","Gournai","Grentemesnil","Griffin","Groulart","Gueron","Guildersleeve","Guyot","Hallé","Haute","Hendry","Heuzé","Holland","Hugonin","Jolland","la Bruiere","la Guierche","la Riviere","Labbé","l'Aigle","Lanquetot","l'Aune","Le Blanc","le Breton","Le Conte","le Despensier","le Gaucher","Le Gras","Le Maistre","Le Marinier","Le Pelletier","Le Prévost","Le Seigneur","Le Tellier","l'Estourmi","Lhuillier","L'ile","Loges","Louet","Lucy","Machault","Maignart","Malleville","Malvallet","Mandeville","Mantel","Marci","Mariage","Martel","Maudit","Maurouard","Medley","Merteberge","Meules","Mobec","Montacute","Mont-Canisi","Montgomery","Morphew","Mortemer","Mucedent","Musard","Mustel","Nesdin","Noyers","Ormond","Ouistreham","Pancevolt","Papon","Parthenai","Pastforeire","Peccoth","Pennant","Perroy","Pevrel","Picvini","Pipin","Pistres","Poer","Pointel","Pontchardon","Poussin","Quesnel","Raimbeaucourt","Rames","Ravenot","Restault","Rivière","Roger","Ros","Roussel","Saint-Clair","Saint-Helene","Saint-Quentin","Saint-Waleri","Scolland","Senlis","Sollers","Strivelyn","Taillebois","Tessel","Thibault","Tibon","Tirel","Touchet","Tournai","Tourneville","Trelli","Valance","Vatteville","Vaux","Venois","Verdun","Verrall","Veteripont","Villon","Vis-de-Loup","Viville","Warci","Willoughby","Achard","Boleyn","Dacre","de Clare","de Montfort","Fairfax","Fitton","Lovell","Mowbray","Quincey","Stafford","Umfraville","Woodville"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newPlayer.AvailablePoints = 10;

            GenderCmbo.Items.Add("Male");
            GenderCmbo.Items.Add("Female");

            strTxt.Enabled = false;
            constTxt.Enabled = false;
            dexTxt.Enabled = false;
            intTxt.Enabled = false;
            wisTxt.Enabled = false;
            chrTxt.Enabled = false;
            lckTxt.Enabled = false;
            availTxt.Enabled = false;

            strCount.Text = "3";
            constCount.Text = "3";
            DexCount.Text = "3";
            IntCount.Text = "3";
            WisCount.Text = "3";
            ChrCount.Text = "3";
            LckCount.Text = "3";
            
            ClassTxt.Enabled = false;
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            newPlayer.Name = NameTxt.Text;
        }

        private void GenderCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            newPlayer.Gender = GenderCmbo.Text;
            strTxt.Enabled = true;
            constTxt.Enabled = true;
            dexTxt.Enabled = true;
            intTxt.Enabled = true;
            wisTxt.Enabled = true;
            chrTxt.Enabled = true;
            lckTxt.Enabled = true;
        }

        private void strTxt_TextChanged(object sender, EventArgs e)
        {
            UpdatePoints();
        }

        private void constTxt_TextChanged(object sender, EventArgs e)
        {
            UpdatePoints();
        }

        private void dexTxt_TextChanged(object sender, EventArgs e)
        {
            UpdatePoints();
        }

        private void intTxt_TextChanged(object sender, EventArgs e)
        {
            UpdatePoints();
        }

        private void wisTxt_TextChanged(object sender, EventArgs e)
        {
            UpdatePoints();
        }

        private void chrTxt_TextChanged(object sender, EventArgs e)
        {
            UpdatePoints();
        }

        private void lckTxt_TextChanged(object sender, EventArgs e)
        {
            UpdatePoints();
        }

        private void availTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            Random name = new Random();
            NameTxt.Text = names[name.Next(0, names.Length)] + " " + names[name.Next(0, names.Length)];
            if (Convert.ToInt32(availTxt.Text) != 10)
            {
                strTxt.Text = "0";
                constTxt.Text = "0";
                dexTxt.Text = "0";
                intTxt.Text = "0";
                wisTxt.Text = "0";
                chrTxt.Text = "0";
                lckTxt.Text = "0";
                availTxt.Text = "0";

                availTxt.Text = "10";
            }
            int pointsRemaining = Convert.ToInt32(availTxt.Text);
            int pointAssigned = 0;
            int ChosenAttribute = 0;

            Random attr = new Random();
            Random Choice = new Random();

            while (pointsRemaining > 0)
            {
                pointAssigned = attr.Next(1, pointsRemaining);
                ChosenAttribute = Choice.Next(1, 7);

                switch (ChosenAttribute)
                {
                    case 1:
                        strTxt.Text = pointAssigned.ToString();
                        break;
                    case 2:
                        constTxt.Text = pointAssigned.ToString();
                        break;
                    case 3:
                        dexTxt.Text = pointAssigned.ToString();
                        break;
                    case 4:
                        intTxt.Text = pointAssigned.ToString();
                        break;
                    case 5:
                        wisTxt.Text = pointAssigned.ToString();
                        break;
                    case 6:
                        chrTxt.Text = pointAssigned.ToString();
                        break;
                    case 7:
                        lckTxt.Text = pointAssigned.ToString();
                        break;
                }
                pointsRemaining -= pointAssigned;
            }
        }

        private void PlayerPicture_Click(object sender, EventArgs e)
        {

        }

        private void ClassPicture_Click(object sender, EventArgs e)
        {

        }

        private void ClassTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            newPlayer.Strength = Convert.ToInt32(strCount.Text);
            newPlayer.Constitution = Convert.ToInt32(constCount.Text);
            newPlayer.Charisma = Convert.ToInt32(ChrCount.Text);
            newPlayer.Dexterity = Convert.ToInt32(DexCount.Text);
            newPlayer.Intelligence = Convert.ToInt32(IntCount.Text);
            newPlayer.Wisdom = Convert.ToInt32(WisCount.Text);
            newPlayer.Luck = Convert.ToInt32(LckCount.Text);

            secondHighestLowestNumber();

            ClassPicture.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + @"\ClassPhotos\ClassIcons\"+ newPlayer.Class +".Jpg";
            PlayerPicture.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + @"\ClassPhotos\ClassChar\" + newPlayer.Gender + "\\" + newPlayer.Class + newPlayer.Gender +".jpg";
            if (newPlayer.Class =="Rogue")
                ClassTxt.Text = newPlayer.Class+": A scoundrel who uses stealth and trickery to overcome obstacles and enemies.";
            if (newPlayer.Class == "Barbarian")
                ClassTxt.Text = newPlayer.Class + ": A fierce warrior of primitive background who can enter a battle rage.";
            if (newPlayer.Class == "Bard")
                ClassTxt.Text = newPlayer.Class + ": An inspiring magician whos power echoes the music of creation.";
            if (newPlayer.Class == "Cleric")
                ClassTxt.Text = newPlayer.Class + ": A priestly champion who wields divine magic in service of a higher power.";
            if (newPlayer.Class == "Druid")
                ClassTxt.Text = newPlayer.Class + ": A priest of the old faith, wielding the powers of nature and adopting animal forms.";
            if (newPlayer.Class == "Fighter")
                ClassTxt.Text = newPlayer.Class + ": A master of martial combat skilled with a variety of weapons and armor";
            if (newPlayer.Class == "Adventurer")
                ClassTxt.Text = newPlayer.Class + ": Commonly found on roads or inns and a universally capable 'Jack of all trades.'";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePoints()
        {
            try
            {
                if (Convert.ToInt32(availTxt.Text) > 0)
                {
                    strCount.Text = Convert.ToString(3 + Convert.ToInt32(strTxt.Text));
                    constCount.Text = Convert.ToString(3 + Convert.ToInt32(constTxt.Text));
                    DexCount.Text = Convert.ToString(3 + Convert.ToInt32(dexTxt.Text));
                    IntCount.Text = Convert.ToString(3 + Convert.ToInt32(intTxt.Text));
                    WisCount.Text = Convert.ToString(3 + Convert.ToInt32(wisTxt.Text));
                    ChrCount.Text = Convert.ToString(3 + Convert.ToInt32(chrTxt.Text));
                    LckCount.Text = Convert.ToString(3 + Convert.ToInt32(lckTxt.Text));

                    int ToBeDecreased = 0;
                    ToBeDecreased += Convert.ToInt32(strCount.Text) - 3;
                    ToBeDecreased += Convert.ToInt32(constCount.Text) - 3;
                    ToBeDecreased += Convert.ToInt32(DexCount.Text) - 3;
                    ToBeDecreased += Convert.ToInt32(IntCount.Text) - 3;
                    ToBeDecreased += Convert.ToInt32(WisCount.Text) - 3;
                    ToBeDecreased += Convert.ToInt32(ChrCount.Text) - 3;
                    ToBeDecreased += Convert.ToInt32(LckCount.Text) - 3;

                    availTxt.Text = Convert.ToString(10 - ToBeDecreased);
                }
                else
                {
                    strTxt.Enabled = false;
                    constTxt.Enabled = false;
                    dexTxt.Enabled = false;
                    intTxt.Enabled = false;
                    wisTxt.Enabled = false;
                    chrTxt.Enabled = false;
                    lckTxt.Enabled = false;
                }
            } catch (Exception) { }
        } 

        private void DeclarePrimeAttributes(int highest, int secondHighest)
        {
            if (newPlayer.Strength == highest)
                newPlayer.HighestAttr = "Strength";
            if (newPlayer.Strength == secondHighest)
                newPlayer.SecondHighestAttr = "Strength";

            if (newPlayer.Constitution == highest)
                newPlayer.HighestAttr = "Constitution";
            if (newPlayer.Constitution == secondHighest)
                newPlayer.SecondHighestAttr = "Constitution";

            if (newPlayer.Dexterity == highest)
                newPlayer.HighestAttr = "Dexterity";
            if (newPlayer.Dexterity == secondHighest)
                newPlayer.SecondHighestAttr = "Dexterity";

            if (newPlayer.Charisma == highest)
                newPlayer.HighestAttr = "Charisma";
            if (newPlayer.Charisma == secondHighest)
                newPlayer.SecondHighestAttr = "Charisma";

            if (newPlayer.Intelligence == highest)
                newPlayer.HighestAttr = "Intelligence";
            if (newPlayer.Intelligence == secondHighest)
                newPlayer.SecondHighestAttr = "Intelligence";

            if (newPlayer.Wisdom == highest)
                newPlayer.HighestAttr = "Wisdom";
            if (newPlayer.Wisdom == secondHighest)
                newPlayer.SecondHighestAttr = "Wisdom";

            if (newPlayer.Luck == highest)
                newPlayer.HighestAttr = "Luck";
            if (newPlayer.Luck == secondHighest)
                newPlayer.SecondHighestAttr = "Luck";

            DecideClass();
        }
        private void DecideClass()
        {
            //Check for Rogue
            if (newPlayer.HighestAttr == "Intelligence" || newPlayer.SecondHighestAttr == "Intelligence")
            {
                if (newPlayer.HighestAttr =="Dexterity" || newPlayer.SecondHighestAttr == "Dexterity")
                {
                    newPlayer.Class = "Rogue";
                }
            }
            //Check for Barbarian
            if (newPlayer.HighestAttr == "Strength" || newPlayer.SecondHighestAttr == "Strength")
            {
                if (newPlayer.HighestAttr == "Constitution" || newPlayer.SecondHighestAttr == "Constitution")
                {
                    newPlayer.Class = "Barbarian";
                }
            }
            //Check for Bard
            if (newPlayer.HighestAttr == "Dexterity" || newPlayer.SecondHighestAttr == "Dexterity")
            {
                if (newPlayer.HighestAttr == "Charisma" || newPlayer.SecondHighestAttr == "Charisma")
                {
                    newPlayer.Class = "Bard";
                }
            }
            //Check for Cleric
            if (newPlayer.HighestAttr == "Wisdom" || newPlayer.SecondHighestAttr == "Wisdom")
            {
                if (newPlayer.HighestAttr == "Charisma" || newPlayer.SecondHighestAttr == "Charisma")
                {
                    newPlayer.Class = "Cleric";
                }
            }
            //Check for Druid
            if (newPlayer.HighestAttr == "Intelligence" || newPlayer.SecondHighestAttr == "Intelligence")
            {
                if (newPlayer.HighestAttr == "Wisdom" || newPlayer.SecondHighestAttr == "Wisdom")
                {
                    newPlayer.Class = "Druid";
                }
            }
            //Check for Fighter
            if (newPlayer.HighestAttr == "Strength" || newPlayer.SecondHighestAttr == "Strength")
            {
                if (newPlayer.HighestAttr == "Dexterity" || newPlayer.SecondHighestAttr == "Dexterity")
                {
                    newPlayer.Class = "Fighter";
                }
            }

            if (newPlayer.Class == "" || newPlayer.Class == null)
            {
                newPlayer.Class = "Adventurer";
            }
        }
        private void updateClassInfo(Player player)
        {
            ClassPicture.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + @"\ClassPhotos\ClassIcons\Bard.Jpg";
            PlayerPicture.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + @"\ClassPhotos\ClassChar\Male\BardMale.jpg";
            ClassTxt.Text = "testc";
        }
        private void secondHighestLowestNumber()
        {
            int[] arr = new int[] {
                newPlayer.Strength,
                newPlayer.Constitution,
                newPlayer.Charisma,
                newPlayer.Dexterity,
                newPlayer.Intelligence,
                newPlayer.Wisdom,
                newPlayer.Luck
            };
            int firstHighestNumber = arr[0];
            int secondHighestNumber = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > firstHighestNumber)
                {
                    firstHighestNumber = arr[i];
                }
            }

            for (int x = 0; x < arr.Length; x++)
            {
                if (arr[x] > secondHighestNumber && firstHighestNumber != arr[x])
                {
                    secondHighestNumber = arr[x];
                }
            }
            DeclarePrimeAttributes(firstHighestNumber, secondHighestNumber);
        }
    }
}
