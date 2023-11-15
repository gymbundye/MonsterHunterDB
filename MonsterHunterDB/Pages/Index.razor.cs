using MonsterHunterDB.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MonsterHunterDB.Pages
{

    public partial class Index
    {
        public bool ShowCreate { get; set; }

        private MonsterDataContext? _context;
        public Monster? NewMonster { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
        }



        public void ShowCreateForm()
        {
            NewMonster = new Monster();
            ShowCreate = true;
        }
        public async Task CreateNewMonster()
        {
            _context ??= await MonsterDataContextFactory.CreateDbContextAsync();

            if (NewMonster is not null)
            {
                _context?.Monsters.Add(NewMonster);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
        }
    }

}
