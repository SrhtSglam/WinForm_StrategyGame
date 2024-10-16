using System.ComponentModel.DataAnnotations;

namespace WinForm_StrategyGame{
    public class Nation{
        public int Id { get; set; }
        public string Name {get; set;}
        public int Army {get;set;}
        public int Manpower {get;set;}
        public int Income {get;set;}
        public int Treasury {get;set;}
    }
}