using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.UserApp.Model;
using UserManagement.UserApp.Services;

namespace UserManagement.UserApp.ModelView
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private ApiService _apiService;
        private List<User> _users;
        private User? _selectedUser;

        public MainViewModel()
        {
            _apiService = new ApiService();
            FetchUsers();
        }

        public User? SelectedUser
        {
            get => _selectedUser;
            set
            {
                if (_selectedUser != value)
                {
                    _selectedUser = value;
                    OnPropertyChanged(nameof(SelectedUser));
                }
            }
        }

        public List<User>? Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        private async void FetchUsers()
        {
            Users = await _apiService.getUsers();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
