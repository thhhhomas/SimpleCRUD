using AutoMapper;
using SOGSA.Api.Models;
using SOGSA.Api.Dtos;

namespace SOGSA.Api.Mapper;

public class MappingProfile : Profile {
  public MappingProfile() {
    CreateMap<Student, StudentResponse>();
    CreateMap<StudentCreate, Student>();
    CreateMap<StudentUpdate, Student>();
  }
}
