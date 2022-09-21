using Microsoft.EntityFrameworkCore;
using MudBlazor;
using StateApprove.Data;
using Telerik.DataSource.Extensions;


namespace StateApprove.Services
{
    public class StageService
    {
        private readonly MyContext _dbContext;

        private List<Stage>? _stages;

        public StageService(MyContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<Stage> GetByIdAsync(int id)
        {
            var stage = await _dbContext.Stages.FindAsync(id);
            return stage;

        }

        public IEnumerable<Stage> GetStages()
        {
            return GetStagesInternal();
        }

        private IEnumerable<Stage> GetStagesInternal()
        {
            if (_stages == null)
            {
                _stages = _dbContext.Stages.ToList();
            }

            return _stages;
        }


        public void CreateStage(Stage stage)
        {
            stage.Name = "User";

            stage.Sequence = _stages.Max(model => model.Sequence) + 1;




            _dbContext.Stages.Add(stage);


            _stages?.Add(stage);

            _dbContext.SaveChanges();

        }


        public void UpdateStage(Stage stage)
        {
            var target = _stages?.FirstOrDefault(p => p.Id == stage.Id);
            if (target != null)
            {
                target.Name = stage.Name;

            }

            _dbContext.SaveChanges();
        }


        public void DeleteStage(Stage stage)
        {
            var target = _stages?.FirstOrDefault(p => p.Id == stage.Id);
            if (target != null)
            {
                _stages?.Remove(target);
                _dbContext.Stages.Remove(target);

                _dbContext.SaveChanges();

                int a = 1;
                foreach (var item in _dbContext.Stages.ToList())
                {
                    item.Sequence = a;
                    a++;

                }

            }

            _dbContext.SaveChanges();

        }

        public void Commit()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
