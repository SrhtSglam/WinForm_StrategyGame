namespace WinForm_StrategyGame{
    public class IDefinitionRepository : IDefinition{
        public void DefinitionItems(Model model){
            if(model.nations == null)
                model.nations = new List<Nation>();
            if(model.nations == null)
                model.nations = new List<Nation>();
            if(model.province == null)
                model.province = new Province();
            if(model.rnd == null)
                model.rnd = new Random();
        }

        public void NationsCreated(Model model){
            model.nations.Add(new Nation(){
                Id = 0,
                Name = "Munster",
                Army = 0,
                Manpower = 0,
                Income = 0,
                Treasury = 1000
            });

            model.nations.Add(new Nation(){
                Id = 1,
                Name = "Connaught",
                Army = 0,
                Manpower = 0,
                Income = 0,
                Treasury = 1000
            });

            model.nations.Add(new Nation(){
                Id = 2,
                Name = "Leinster",
                Army = 0,
                Manpower = 0,
                Income = 0,
                Treasury = 1000
            });

            model.nations.Add(new Nation(){
                Id = 3,
                Name = "Ulster",
                Army = 0,
                Manpower = 0,
                Income = 0,
                Treasury = 1000
            });

        }
    }
}