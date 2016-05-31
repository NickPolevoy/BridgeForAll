namespace SharedModels
{
    using System.Collections.ObjectModel;

    
    public class Hands: ObservableCollection<Hand>, IHands
    {
        public Hand South { get; set; } = new Hand();

        public Hand West { get; set; } = new Hand();

        public Hand North { get; set; } = new Hand();

        public Hand East { get; set; } = new Hand();
    }
}
