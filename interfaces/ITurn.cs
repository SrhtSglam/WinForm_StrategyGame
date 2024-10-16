namespace WinForm_StrategyGame{
    public interface ITurn{
        void NextTurn(Model model, frmGame frm);
        void NewArmy(Model model, frmGame frm);
        void EventCreator(Model model, frmGame frm);
    }
}