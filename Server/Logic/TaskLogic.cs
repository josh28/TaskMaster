using System.Collections.Generic;
using Server.Entities;

namespace Server.Logic
	    IEnumerable<Task> GetTasks();
	}
	    private readonly IRepository _repository;

	    public TaskLogic(IRepository repository)
	    {
	        _repository = repository;
	    }

	    public IEnumerable<Task> GetTasks()
	    {
	        return _repository.FindMany<Task>();
	    }
	}