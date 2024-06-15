namespace OMB.Aplication.SedeUseCases;

using OMB.Aplication.Interfaces;

public class deleteSedeUseCase {

    public readonly ISedeRepository repository;

    public deleteSedeUseCase (ISedeRepository repository) {
        this.repository = repository;
    }

    public void Execute (int sedeId) {
        repository.deleteSede(sedeId);
    }

}