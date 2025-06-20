using System;
using Microsoft.EntityFrameworkCore;

namespace BB_NayiDisha_New.Models.DataContext;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base(options)
		{

		}
}
