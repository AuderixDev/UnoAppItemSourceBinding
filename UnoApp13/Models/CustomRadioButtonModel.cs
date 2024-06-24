using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoApp13.Models;
public partial class CustomRadioButtonModel
{
    public string ButtonText { get; set; }

    public ICommand ButtonCommand { get; set; }

    public IState<bool> CustomRadioButtonIsEnabled => State<bool>.Empty(this);

    public async Task SetCustomRadioButtonIsEnabled(bool enabled)
    {
            await CustomRadioButtonIsEnabled.SetAsync(enabled);
    }

}
