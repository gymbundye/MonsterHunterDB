using MonsterHunterDB.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MonsterHunterDB.Pages
{

    public partial class Index
    {
        public bool ShowCreate { get; set; }
        public bool ShowEdit { get; set; }
        public bool EditRecord { get; set; }
        public int EditingId { get; set; }

        public Monster? MonsterToUpdate { get; set; }

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

            
        }

        //This method allows us to update our monsters an example of update//
        

        public async Task ShowEditForm(Monster ourMonster)
        {

            _context ??= await MonsterDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                MonsterToUpdate = _context.Monsters.FirstOrDefault(x => x.Id == ourMonster.Id);
                ShowEdit = true;
                EditingId = ourMonster.Id;
            }
        }

        public async Task UpdateMonster()
        {
            _context ??= await MonsterDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (MonsterToUpdate is not null) _context.Monsters.Update(MonsterToUpdate);
                await _context.SaveChangesAsync();
            }
            ShowEdit = false;
        }

        //This is our delete method//
        public async Task DeleteMonster(Monster ourMonster)
        {
            _context ??= await MonsterDataContextFactory.CreateDbContextAsync();
            if (_context is not null)
            {
                if (ourMonster is not null) _context.Monsters.Remove(ourMonster);
                await _context.SaveChangesAsync();
            }
            await ShowMonsters();

        }
    }
}
