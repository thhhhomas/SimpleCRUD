using SOGSA.Api.Database;
using SOGSA.Api.Dtos;
using SOGSA.Api.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace SOGSA.Api.Services;

public class StudentService(SogsaDbContext _context, IMapper _mapper) : IStudentService {

  public async Task<IReadOnlyList<StudentResponse>> GetStudentsAsync() 
    => _mapper.Map<List<StudentResponse>>(await _context.Students.ToListAsync());

  public async Task<StudentResponse?> GetStudentByIdAsync(long id)
    => _mapper.Map<StudentResponse>(await _context.Students.FindAsync(id));

  public async Task<StudentResponse> CreateStudentAsync(StudentCreate studentCreate) {
    var student = _mapper.Map<Student>(studentCreate);

    await _context.Students.AddAsync(student);
    await _context.SaveChangesAsync();

    return _mapper.Map<StudentResponse>(student);
  }

  public async Task<bool> UpdateStudentAsync(long id, StudentUpdate student) {
    var existingStudent = await _context.Students.FindAsync(id);

    if (existingStudent is null) return false;

    _mapper.Map(student, existingStudent);

    await _context.SaveChangesAsync();
    return true;
  }

  public async Task<bool> DeleteStudentAsync(long id){
    var student = await _context.Students.FindAsync(id);

    if (student is null) return false;
    
    _context.Students.Remove(student);
    await _context.SaveChangesAsync();

    return true;
  }
}
