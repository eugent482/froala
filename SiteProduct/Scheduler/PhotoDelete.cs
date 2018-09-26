using Quartz;
using SiteProduct.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SiteProduct.Scheduler
{
    public class PhotoDelete : IJob
    {
        private readonly ApplicationDbContext _context;
        public PhotoDelete()
        {
            _context = new ApplicationDbContext();
        }
        public async Task Execute(IJobExecutionContext context)
        {
            await DeletePhotos();
        }

       public Task DeletePhotos()
        {
            return Task.Run(() =>
            {
                DateTime currenttime = DateTime.Now;
                foreach (var item in _context.ProductDescriptionImages)
                {
                    if((DateTime.Now-item.LoadDate).Hours>3 && item.ProductId==null)
                    {
                        _context.ProductDescriptionImages.Remove(item);
                    }                    
                }
                _context.SaveChanges();
            });
        }
    }
}