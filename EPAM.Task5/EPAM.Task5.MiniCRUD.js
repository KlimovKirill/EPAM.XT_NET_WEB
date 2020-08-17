'use strict';

class Storage{
    
    constructor(name, description){
        this.name = name;
        this.description = description;
        this.id = 1;
    };
}

class StorageManager{
    
    constructor(){
        this.storageList = [];
    }

    addItem(object){

        if(typeof object == 'object')
        {
            if(object.name === '' || object.description === ''){
                console.log("Error! Please fill the fields!")
            }
            else{
                object.id = (this.storageList.length + 1).toString();
                this.storageList.push(object);
            }
        }
        else
        {
            console.log("Error! You need to pass the Object parameter!");
        }
    } 

    getItemById(itemId){

        itemId = itemId.toString();

        var requiredItem = this.storageList.find(storage => storage.id === itemId);
        if(requiredItem)
        {
            console.log(`ID: ${requiredItem.id} | Name: ${requiredItem.name} | Description: ${requiredItem.description}`);
            return requiredItem;
        }
        else
        {
            console.log(`NULL! There is no item with id = ${itemId}`);
            return null;
        }
    }

    getAllItems(){

        if(!!this.storageList.length)
        {
            for (var i in this.storageList)
            {
                console.log(`ID: ${this.storageList[i].id} | Name: ${this.storageList[i].name} | Description: ${this.storageList[i].description}`);
            }

            return this.storageList;
        }
        else
        {
            console.log('Array is empty! Firstly add the elements!');
        }
    }
    
    deleteItemById(itemId){

        itemId = itemId.toString();

        var requiredItem = this.storageList.find(storage => storage.id === itemId);

        if(requiredItem){

            this.storageList.forEach((storage, index) => {
            if(storage.id === itemId)
            {
                var result = this.getItemById(itemId);
                delete this.storageList[index];
                return result;
            }
            });
        }
        else
        {
            console.log('The ID you enter does not exists in DataBase! Element did not deleted.');
        }
    }

    updateItemById(itemId, object){

        itemId = itemId.toString();

        if(typeof object == 'object')
        {
            for (var i = 0; i < this.storageList.length; i++)
            {
                if(this.storageList[i].id === itemId)
                {
                    this.storageList[i].name = object.name;
                    this.storageList[i].description = object.description;
                }
            }
        }
        else
        {
            console.log("Error! You need to pass the Object parameter!");
        }
    }

    replaceItemById(itemId, object){

        itemId = itemId.toString();

        if(typeof object == 'object')
        {
            this.storageList.forEach((storage,index) => {
                if(storage.id === itemId)
                {
                    object.id = itemId;
                    this.storageList.splice(index, 1, object);
                }
            });
        }
        else
        {
            console.log("Error! You need to pass the Object parameter!");
        }
    }   
}

//Testing of the library

var sm = new StorageManager();

sm.addItem(new Storage('Pulp Fiction','Tarantino'));
sm.addItem(new Storage('Three Comrades','The Best One'));
sm.addItem(new Storage('XOYO','Aint no love'));

console.log('All existing elements in Array:');
sm.getAllItems();

console.log('Requested element:');
sm.getItemById(3);

sm.replaceItemById(3, new Storage('Ford','Explorer'));
sm.updateItemById(2, new Storage('Tesla','Batut'));

console.log('All existing elements in Array:');
sm.getAllItems();

console.log('Deleted element:');
sm.deleteItemById(1);

console.log('All existing elements in Array:');
sm.getAllItems();

sm.addItem(new Storage('PARTYNEXTDOOR','Curious'));

console.log('All existing elements in Array:');
sm.getAllItems();

