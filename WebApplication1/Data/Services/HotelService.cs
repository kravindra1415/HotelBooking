using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Dto;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Services
{
    public class HotelService : IHotelService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HotelService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<HotelDto>> GetAllAsync()
        {
            var hotels = await _context.Hotels.Select(h => _mapper.Map<HotelDto>(h)).ToListAsync();
            return hotels;
        }

        public async Task<HotelDto> GetByIdAsync(int id)
        {
            var hotel = await _context.Hotels.FirstOrDefaultAsync(h => h.Id == id);
            return _mapper.Map<HotelDto>(hotel);
        }

        public async Task CreateAsync(HotelDto hotelDto)
        {
            var hotelAdd = _mapper.Map<Hotel>(hotelDto);

            _context.Add(hotelAdd);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deptToDelete = await _context.Hotels.SingleAsync(d => d.Id == id);

            _context.Hotels.Remove(deptToDelete);
            await _context.SaveChangesAsync();
        }

        //public async Task UpdateAsync(DepartmentViewModel departmentViewModel)
        //{
        //    var departmentToUpdate = await _dbContext.Departments.SingleAsync(d => d.Id == departmentViewModel.Id);

        //    departmentToUpdate.Name = departmentViewModel.Name;
        //    departmentToUpdate.Description = departmentViewModel.Description;

        //    _dbContext.Departments.Update(departmentToUpdate);
        //    await _dbContext.SaveChangesAsync();
        //}
    }
}
