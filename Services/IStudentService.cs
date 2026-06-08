using SOGSA.Api.Dtos;

namespace SOGSA.Api.Services;

public interface IStudentService {
  Task<IReadOnlyList<StudentResponse>> GetStudentsAsync();
  Task<StudentResponse?> GetStudentByIdAsync(long id);
  Task<StudentResponse> CreateStudentAsync(StudentCreate student);
  Task<bool> UpdateStudentAsync(long id, StudentUpdate student);
  Task<bool> DeleteStudentAsync(long id);
}
