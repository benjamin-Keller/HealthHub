using HealthHub.Client.Model;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace HealthHub.Client.Pages.Users;

public partial class ViewUsers
{
    bool success;
    AddUserViewModel model = new AddUserViewModel();
    private void OnValidSubmit(EditContext context)
    {
        success = true;
        StateHasChanged();
    }
}