using StarterApp.Database.Models;
using System.Collections.Generic;
using System.Linq;


namespace StarterApp.Database.Data.Repositories;
public class ItemRepository
{
    private readonly List<Item> _items = new();
    private int _nextId = 1;

    public List<Item> GetAll() => _items;

    public void Add(Item item)
    {
        item.Id = _nextId++;
        _items.Add(item);
    }

    public Item GetById(int id)
    {
        return _items.FirstOrDefault(i => i.Id == id);
    }
}