using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    using System.Collections.ObjectModel;

    public class Hand
    {
        public ObservableCollection<Card> SetCards { get; set; } = new ObservableCollection<Card>();

        public int Points { get; set; }
        public bool? Vulnerability { get; set; }
    }
}


