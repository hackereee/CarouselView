**注： 这里只讨论Android这条线的源码**
* CacheImage 最终数据加载默认会在DataResolverFactory.cs当中构造，通过GetResolver方法根据Source类型取得数据源加载方案。