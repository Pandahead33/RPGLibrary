namespace puskaric.RoleplayingGameLibrary
{
    public interface ICharacter
    {
        //Properties
        string CharacterClass { get; }
        string Name { get; }
        int Health { get; }

        //Methods
        void PerformAttack(ICharacter targer);
        void ReceiveAttack(int damage); 
    }
}
