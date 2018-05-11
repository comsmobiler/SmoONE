编码规范：
1. 任何对基础代码的改造都要考虑是否会对ISV现有的调用造成影响，否则后果很严重
2. 本工程基于.NET 2.0，请不要引入.NET 2.0以上的依赖
3. .NET里面的方法和属性的首字母都是大写的，类变量的首字母则是小写的
4. .NET里面的基本类型请尽量用bool, object, string, int, long, double, float等，不要用大写那个
5. .NET里面的接口名称请采用I开头，实现类不要加Impl结尾
6. 尽量避免使用interface（尽可能多的用delegate），.NET里面的interface没有匿名实现的功能
