using HealthHub.Client.Services;
using HealthHub.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace HealthHub.Client.Pages.Users;

public partial class AddUser
{
    [Inject] private AuthService _authService { get; set; }
    bool success;
    AddUserViewModel model = new AddUserViewModel();
    private async Task OnValidSubmitAsync(EditContext context)
    {
        try
        {
            var response = await _authService.SaveUserAsync(model);
            if (response.IsSuccessStatusCode)
            {
                success = true;
                //Show success toast
            }
            else
            {
                success = false;
                //Show something went wrong toast
            }
        }
        finally
        {
            StateHasChanged();
        }
    }
}