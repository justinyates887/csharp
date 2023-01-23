using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return knightIsAwake ? false : true;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return archerIsAwake ? false : true && prisonerIsAwake ? true : false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent){
            return archerIsAwake ? false : true;
        } else {
            return archerIsAwake ? false : true && knightIsAwake ? false : true && prisonerIsAwake ? true : false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
