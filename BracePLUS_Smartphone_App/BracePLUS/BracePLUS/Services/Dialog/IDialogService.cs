﻿using System.Threading.Tasks;

namespace BracePLUS.Services
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
    }
}
