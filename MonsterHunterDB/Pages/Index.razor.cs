using System.Threading.Tasks;

namespace MonsterHunterDB.Pages
{

	public partial class Index
	{
        public bool ShowCreate { get; set; }
    }
    protected override async Task OnInitializedAsync()
    {
        ShowCreate = false;
    }

    private MonsterDataContext? _context;
    public Monster? NewMonter { get; set; }

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
