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
