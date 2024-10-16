namespace WinForm_StrategyGame{
    public class Model{
        public List<Nation> nations {get; set;}
        public Province province {get; set;}
        public int EventTick {get; set;}
        public Random rnd {get; set;}
        public int pcbNumber{get;set;} = 0;
    }
}