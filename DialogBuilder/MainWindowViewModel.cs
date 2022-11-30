using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBuilder;
public class MainWindowViewModel : Conductor<IScreen>.Collection.OneActive
{

    public MainWindowViewModel()
    {
        this.DisplayName = "Dialog Builder";
    }
}
