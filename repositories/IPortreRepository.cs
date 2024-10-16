using System.Windows.Forms;

namespace WinForm_StrategyGame{
    public class IPortreRepository : IPortre{
        PictureBox pcbNew;
        public void CreateDynastyTable(Model model, frmGame frm){
            if(pcbNew == null)
                pcbNew = new PictureBox();
            pcbNew.Name = "pcbNew" + model.pcbNumber;
            model.pcbNumber++;
            pcbNew.Size = new Size(160, 180);
            pcbNew.Location = new Point(400, 180);
            pcbNew.BackColor = Color.White;
            pcbNew.Visible = true;
            pcbNew.BringToFront();
            pcbNew.Image = Image.FromFile("img/Map_Default.png");
            pcbNew.SizeMode = PictureBoxSizeMode.CenterImage;
            frm.Controls.Add(pcbNew);
        }

        public void DeleteDynastyTable(Model model, frmGame frm){
            if(pcbNew == null)
                pcbNew = new PictureBox();
            frm.Controls.Remove(pcbNew);
        }
    }
}