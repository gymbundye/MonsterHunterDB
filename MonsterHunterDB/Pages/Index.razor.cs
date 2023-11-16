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

        public List<Monster>? OurMonsters { get; set; }   

        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
            await ShowMonsters();
        }



        public void ShowCreateForm()
        {
            NewMonster = new Monster();
            ShowCreate = true;
        }

        // This Method adds a New Monster to the Database an example of Create//
        public async Task CreateNewMonster()
        {
            _context ??= await MonsterDataContextFactory.CreateDbContextAsync();

            if (NewMonster is not null)
            {
                _context?.Monsters.Add(NewMonster);
                _context?.SaveChangesAsync();
            }
            ShowCreate = false;
            await ShowMonsters();
        }

        //This Method Shows the List of our Monsters an example of Read//

        public async Task ShowMonsters()
        {
            _context ??= await MonsterDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                OurMonsters = await _context.Monsters.ToListAsync();
            }

            if (_context is not null) await _context.DisposeAsync();
        }
    }

}
