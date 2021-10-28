# Observer Design Pattern 


###   Not make every class that implements Observable deal with implementing the addObserver, removeObserver and notify methods, and maintaining a list of observers. Instead have one class (ConcreteObserver) that implements all this and can be reused.
###    Not make every class that implements Observable have to extend ConcreteObserver, instead allow them to wrap ConcreteObserver and forward the methods in order to implement Observable.

###   Not have to do any class casting, particularly in implementations of the Observer.notify method, instead use generics.

![image](https://user-images.githubusercontent.com/90280719/138606640-47230538-4cd2-481a-af35-316c2ccd522f.png)
