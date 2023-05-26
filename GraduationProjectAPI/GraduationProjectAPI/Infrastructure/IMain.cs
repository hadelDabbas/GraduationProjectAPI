using GraduationProjectAPI.Dto;
using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IMain
    {
        List<PostDto> Posts(int id);
    }
}
