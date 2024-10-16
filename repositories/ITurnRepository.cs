using System.Net.Security;

namespace WinForm_StrategyGame{
    public class ITurnRepository : ITurn{
        Random rnd;
        public void NextTurn(Model model, frmGame frm){
            model.EventTick--;
            if(model.EventTick < 0){
                EventCreator(model, frm);
                model.EventTick = rnd.Next(5,30);
            }
            string imagePath;
            foreach(var items in model.ownerProvinces){
                imagePath = items.NameId + items.FirstId.ToString() + "_" + items.LastId.ToString();
            }

            if(rnd == null){
                rnd = new Random();
            }
            foreach(var items in model.nations){
                items.Income = rnd.Next(-100, 100) * model.ownerProvinces.Count;
                items.Treasury = items.Treasury + items.Income;
                items.Manpower += rnd.Next(0, 100) * model.ownerProvinces.Count;
            }

            string armyText, manpowerText, incomeText, treasuryText;

            armyText = model.nations[0].Army.ToString() + " Ordu";
            manpowerText = model.nations[0].Manpower.ToString() + " MP";
            if(model.nations[0].Income > 0){
                incomeText = "+" + model.nations[0].Income.ToString();
            }
            else if(model.nations[0].Income < 0){
                incomeText = model.nations[0].Income.ToString();
            }
            else{
                incomeText = model.nations[0].Income.ToString();
            }
            treasuryText = model.nations[0].Treasury.ToString() + "G";

            frm.lblNationName.Text = frm.model.nations[0].Name; //Index 0 daki ülke bizim ülkemiz
            frm.lblArmy.Text = armyText;
            frm.lblManPower.Text = manpowerText;
            frm.lblIncome.Text = incomeText;
            frm.lblTreasury.Text = treasuryText;

            // frm.pcbMap.Image = Image.FromFile($"{model.ownerProvinces[0].NameId}{model.ownerProvinces[0].FirstId.ToString()}_{model.ownerProvinces[0].LastId.ToString()}");
            frm.pcbMap.Image = Image.FromFile($"img/{model.ownerProvinces[0].FolderName}/{model.ownerProvinces[0].NameId}{model.ownerProvinces[0].FirstId.ToString()}_{model.ownerProvinces[0].LastId.ToString()}.png");
            // MessageBox.Show($"img/{model.ownerProvinces[0].NameId}{model.ownerProvinces[0].FirstId.ToString()}_{model.ownerProvinces[0].LastId.ToString()}.png");
        }

        public void NewArmy(Model model, frmGame frm){
            int mp = model.nations[0].Manpower;
            int armyCount = model.nations[0].Army;
            if(mp > 500){
                mp -= 500;
                armyCount++;
            }
            else{
                MessageBox.Show("Yetersiz Asker Gücü");
            }
            model.nations[0].Army = armyCount;
            model.nations[0].Manpower = mp;
            NextTurn(model, frm);
        }

        public void EventCreator(Model model, frmGame frm){
            int eventNum = rnd.Next(0, 4);
            switch (eventNum){
                case 0:
                    MessageBox.Show("Topraklarınızdan birinde doğal afet oldu.\n-500 MP", "Afet");
                    model.nations[0].Manpower -= 500;
                break;
                case 1:
                    DialogResult dr = MessageBox.Show("Bir ülke sana katılmak istedi.", "Birleşme", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes){
                        int randomNumber = rnd.Next(0, 2);
                        Event_LandChange(model, frm, randomNumber);
                        model.ownerProvinces[0].FirstId++;
                    }
                    else{
                        MessageBox.Show("Kabul Edilmedi");
                    }
                break;
                case 2:
                    MessageBox.Show("Başka bir ülke size 500 para yolladı.\n+500 G", "Hediye");
                    model.nations[0].Treasury += 500;
                break;
                case 3:
                    MessageBox.Show("Yeni bir çocuğunuz oldu.\n+1 Yeni Çocuk", "Yeni Varis");
                break;
            }
        }

        public void Event_LandChange(Model model, frmGame frm, int rndNum){
            if(model.ownerProvinces[0].FirstId == 1)
                model.ownerProvinces[0].FirstId++;
            else if(model.ownerProvinces[0].FirstId == 2 && model.ownerProvinces[0].LastId == 1){
                model.ownerProvinces[0].LastId++;
            }
            else if(model.ownerProvinces[0].NameId == "M" || model.ownerProvinces[0].NameId == "U" && model.ownerProvinces[0].FirstId == 2 && model.ownerProvinces[0].LastId == 2){
                model.ownerProvinces[0].FirstId++;
            }
            else if(model.ownerProvinces[0].NameId == "C" || model.ownerProvinces[0].NameId == "L" && model.ownerProvinces[0].FirstId == 2 && model.ownerProvinces[0].LastId == 2){
                model.ownerProvinces[0].FirstId++;
            }

        }
    }
}